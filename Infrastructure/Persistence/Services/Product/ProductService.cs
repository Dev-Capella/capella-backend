using Application.DataTransferObject;
using Application.Repositories;
using Application.Repositories.ProductAbstract;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Domain.Enums;

namespace Persistence.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IMediaService _mediaService;
        private readonly IProductReadRepository _productReadRepository;
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly IBrandReadRepository _brandReadRepository;
        private readonly IVariantReadRepository _variantReadRepository;
        private readonly ITagReadRepository _tagReadRepository;
        private readonly ISupplierReadRepository _supplierReadRepository;
        private readonly IClassificationAttributeValueService _classificationAttributeValueService;
        private readonly IVariantItemService _variantItemService;
        private readonly IMediaWriteRepository _mediaWriteRepository;
        private readonly IMediaFormatReadRepository _mediaFormatReadRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            ICategoryReadRepository categoryReadRepository,
            IMediaService mediaService,
            IClassificationAttributeValueService classificationAttributeValueService,
            IVariantItemService variantItemService,
            IVariantReadRepository variantReadRepository,
            IBrandReadRepository brandReadRepository,
            ISupplierReadRepository supplierReadRepository,
            ITagReadRepository tagReadRepository,
            IMediaWriteRepository mediaWriteRepository,
            IMediaFormatReadRepository mediaFormatReadRepository,
            IMapper mapper)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _categoryReadRepository = categoryReadRepository;
            _classificationAttributeValueService = classificationAttributeValueService;
            _mediaService = mediaService;
            _variantItemService = variantItemService;
            _tagReadRepository = tagReadRepository;
            _brandReadRepository = brandReadRepository;
            _supplierReadRepository = supplierReadRepository;
            _variantReadRepository = variantReadRepository;
            _mediaWriteRepository = mediaWriteRepository;
            _mediaFormatReadRepository = mediaFormatReadRepository;
            _mapper = mapper;
        }

        #region SaveProduct

        public async Task Save(ProductDto productDto)
        {
            var transaction = await _productWriteRepository.DbTransactional();
            Product product = new();
            product.Name = productDto.Name;
            product.Description = productDto.Description;
            product.Active = productDto.Active;
            product.Code = Guid.NewGuid().ToString();
            product.Price = productDto.Price != null ? (decimal)productDto.Price : 0;
            product.DiscountedPrice = productDto.DiscountedPrice != null ? (decimal)productDto.DiscountedPrice : 0;

            try
            {
                var categories = new HashSet<Category>();
                foreach (var item in productDto.Categories)
                {
                    var category = _categoryReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefault();
                    categories.Add(category);
                }

                product.Categories = categories;

                var classificationAttributeValues = new HashSet<ClassificationAttributeValue>();
                foreach (var item in productDto.ClassificationAttributeValues)
                {
                    var classificationAttributeValue = await _classificationAttributeValueService.Save(item);
                    classificationAttributeValues.Add(classificationAttributeValue);
                }

                product.ClassificationAttributeValues = classificationAttributeValues;

                var variants = new HashSet<Variant>();
                foreach (var item in productDto.Variants)
                {
                    var variant = await _variantReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefaultAsync();
                    variants.Add(variant);
                }

                product.Variants = variants;

                var variantItems = new HashSet<VariantItem>();
                foreach (var item in productDto.VariantItems)
                {
                    var variantItem = await _variantItemService.Save(item);
                    variantItems.Add(variantItem);
                }

                product.VariantItems = variantItems;

                var brand = await _brandReadRepository.GetWhere(x => x.Code == productDto.Brand.Code)
                    .FirstOrDefaultAsync();
                product.Brand = brand;

                var supplier = await _supplierReadRepository.GetWhere(x => x.Code == productDto.Supplier.Code)
                    .FirstOrDefaultAsync();
                product.Supplier = supplier;

                var tags = new HashSet<Tag>();
                foreach (var item in productDto.Tags)
                {
                    var tag = await _tagReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefaultAsync();
                    tags.Add(tag);
                }

                product.Tags = tags;

                var galleries = new HashSet<Gallery>();
                var mediaFormats = await _mediaFormatReadRepository
                    .GetWhere(x =>
                        x.MediaFormatType == MediaFormatType.PRODUCT || x.MediaFormatType == MediaFormatType.ALL)
                    .ToListAsync();
                Parallel.ForEach(productDto.Files, item =>
                {
                    var model = _mediaService.SaveGalleryForBinary(item, mediaFormats, true);
                    galleries.Add(model);
                });

                foreach (var gallery in galleries)
                {
                    await _mediaWriteRepository.AddRangeAsync(gallery.Medias);
                }

                product.Galleries = galleries;

                await _productWriteRepository.AddAsync(product);

                transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
        }

        #endregion

        public async Task<List<ProductListDto>> GetAllProducts()
        {
            var products = await _productReadRepository.GetAllWithIncludeStringParam(true,
                "Categories",
                "Variants",
                "Brand",
                "Tags",
                "Galleries.Medias.MediaFormat",
                "VariantItems.Galleries.Medias.MediaFormat").ToListAsync();
            var productsDto = _mapper.Map<List<ProductListDto>>(products);
            return productsDto;
        }

        public async Task<ProductDto> GetProductByCode(string code)
        {
            var product = await _productReadRepository.GetWhere(x => x.Code == code)
                .Include(x => x.Categories)
                .Include(x => x.ClassificationAttributeValues)
                .ThenInclude(cav => cav.Options)
                .Include(x => x.ClassificationAttributeValues)
                .ThenInclude(cav => cav.Classification)
                .ThenInclude(c => c.Options)
                .Include(x => x.Variants)
                .Include(x => x.VariantItems)
                .ThenInclude(variantItems => variantItems.ClassificationAttributeValues)
                .ThenInclude(classificationAttributeValues => classificationAttributeValues.Options)
                .Include(x => x.VariantItems)
                .ThenInclude(variantItems => variantItems.ClassificationAttributeValues)
                .ThenInclude(classificationAttributeValues => classificationAttributeValues.Classification)
                .ThenInclude(classification => classification.Options)
                .Include(x => x.VariantItems)
                .ThenInclude(x => x.VariantValues)
                .Include(x => x.VariantItems)
                .ThenInclude(variantItems => variantItems.Galleries)
                .ThenInclude(galleries => galleries.Medias.Where(m => m.MediaFormat.Code == "original"))
                .Include(x => x.Brand)
                .Include(x => x.Tags)
                .Include(x => x.Galleries)
                .ThenInclude(galleries => galleries.Medias.Where(m => m.MediaFormat.Code == "original"))
                .Include(x => x.Supplier)
                .FirstOrDefaultAsync();

            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }

        public async Task Delete(string code)
        {
            var product = _productReadRepository.GetWhere(x => x.Code == code).FirstOrDefault();
            await _productWriteRepository.RemoveAsync(product);
        }

        #region UpdateProduct

        public async Task Update(ProductDto productDto)
        {
            var product = await _productReadRepository.GetWhere(x => x.Code == productDto.Code)
                .Include(x => x.Categories)
                .Include(x => x.ClassificationAttributeValues)
                .ThenInclude(cav => cav.Options)
                .Include(x => x.ClassificationAttributeValues)
                .ThenInclude(cav => cav.Classification)
                .ThenInclude(c => c.Options)
                .Include(x => x.Variants)
                .Include(x => x.VariantItems)
                .ThenInclude(variantItems => variantItems.ClassificationAttributeValues)
                .ThenInclude(classificationAttributeValues => classificationAttributeValues.Options)
                .Include(x => x.VariantItems)
                .ThenInclude(variantItems => variantItems.ClassificationAttributeValues)
                .ThenInclude(classificationAttributeValues => classificationAttributeValues.Classification)
                .ThenInclude(classification => classification.Options)
                .Include(x => x.VariantItems)
                .ThenInclude(x => x.VariantValues)
                .Include(x => x.VariantItems)
                .ThenInclude(variantItems => variantItems.Galleries)
                .ThenInclude(galleries => galleries.Medias.Where(m => m.MediaFormat.Code == "original"))
                .Include(x => x.Brand)
                .Include(x => x.Tags)
                .Include(x => x.Galleries)
                .Include(x => x.Supplier)
                .FirstOrDefaultAsync();
            var transaction = await _productWriteRepository.DbTransactional();
            try
            {
                product.Name = productDto.Name;
                product.Description = productDto.Description;
                product.Active = productDto.Active;
                product.Price = productDto.Price != null ? (decimal)productDto.Price : 0;
                product.DiscountedPrice = productDto.DiscountedPrice != null ? (decimal)productDto.DiscountedPrice : 0;
                var categories = new HashSet<Category>();
                foreach (var item in productDto.Categories)
                {
                    var category = _categoryReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefault();
                    categories.Add(category);
                }

                product.Categories = categories;

                var classificationAttributeValues = new HashSet<ClassificationAttributeValue>();
                foreach (var item in productDto.ClassificationAttributeValues)
                {
                    if (product.ClassificationAttributeValues.Select(x => x.Code).Any(x => x == item.Code))
                    {
                        var modifiedclassificationattributevalue =
                            await _classificationAttributeValueService.Update(item);
                        classificationAttributeValues.Add(modifiedclassificationattributevalue);
                    }
                    else
                    {
                        var modifiedclassificationattributevalue =
                            await _classificationAttributeValueService.Save(item);
                        classificationAttributeValues.Add(modifiedclassificationattributevalue);
                    }
                }

                var notContainsClassificationAttributeValueModel = product.ClassificationAttributeValues
                    .Select(x => x.Code)
                    .Where(x => !productDto.ClassificationAttributeValues.Select(x => x.Code).Contains(x)).ToList();
                foreach (var item in notContainsClassificationAttributeValueModel)
                {
                    await _classificationAttributeValueService.Delete(item);
                }

                product.ClassificationAttributeValues = classificationAttributeValues;

                var variants = new HashSet<Variant>();
                foreach (var item in productDto.Variants)
                {
                    var variant = await _variantReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefaultAsync();
                    variants.Add(variant);
                }

                product.Variants = variants;

                var variantItems = new HashSet<VariantItem>();
                foreach (var item in productDto.VariantItems)
                {
                    if (product.VariantItems.Select(x => x.Code).Any(x => x == item.Code))
                    {
                        var modifiedVariantItem = await _variantItemService
                            .Update(item,
                                product.VariantItems.Where(x => x.Code == item.Code).Select(y => y.Galleries)
                                    .FirstOrDefault(),
                                product.VariantItems.Where(x => x.Code == item.Code)
                                    .Select(y => y.ClassificationAttributeValues).FirstOrDefault());
                        variantItems.Add(modifiedVariantItem);
                    }
                    else
                    {
                        var variantItem = await _variantItemService.Save(item);
                        variantItems.Add(variantItem);
                    }
                }

                product.VariantItems = variantItems;

                var brand = await _brandReadRepository.GetWhere(x => x.Code == productDto.Brand.Code)
                    .FirstOrDefaultAsync();
                product.Brand = brand;

                var supplier = await _supplierReadRepository.GetWhere(x => x.Code == productDto.Supplier.Code)
                    .FirstOrDefaultAsync();
                product.Supplier = supplier;

                var tags = new HashSet<Tag>();
                foreach (var item in productDto.Tags)
                {
                    var tag = await _tagReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefaultAsync();
                    tags.Add(tag);
                }

                product.Tags = tags;

                var galleries = new HashSet<Gallery>();
                foreach (var item in product.Galleries)
                {
                    if (!(productDto.Galleries.Select(x => x.Code).Any(x => x == item.Code)))
                    {
                        await _mediaService.DeleteGallery(item.Code);
                    }
                    else
                    {
                        galleries.Add(item);
                    }
                }

                var mediaFormats = await _mediaFormatReadRepository
                    .GetWhere(x =>
                        x.MediaFormatType == MediaFormatType.PRODUCT || x.MediaFormatType == MediaFormatType.ALL)
                    .ToListAsync();

                if (productDto.Files!=null && productDto.Files.Any())
                {
                    Parallel.ForEach(productDto.Files, item =>
                    {
                        var media = _mediaService.SaveGalleryForBinary(item, mediaFormats, true);
                        galleries.Add(media);
                    });
                }

                product.Galleries = galleries;

                await _productWriteRepository.UpdateAsyncModel(product);

                transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                transaction.RollbackAsync();
            }
        }

        #endregion
    }
}