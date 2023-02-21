using Application.DataTransferObject;
using Application.Repositories;
using Application.Repositories.ProductAbstract;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class VariantItemService : IVariantItemService
    {
        private readonly IVariantItemReadRepository _variantItemReadRepository;
        private readonly IVariantValueReadRepository _variantValueReadRepository;
        private readonly IVariantItemWriteRepository _variantItemWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IMediaService _mediaService;
        private readonly IClassificationAttributeValueService _classificationAttributeValueService;
        private readonly IMediaFormatReadRepository _mediaFormatReadRepository;
        private readonly IMapper _mapper;
        public VariantItemService(IVariantItemReadRepository variantItemReadRepository, 
            IClassificationAttributeValueService classificationAttributeValueService,
            IVariantValueReadRepository variantValueReadRepository, 
            IVariantItemWriteRepository variantItemWriteRepository,
            IMediaService mediaService,
            IMapper mapper,
            IMediaFormatReadRepository mediaFormatReadRepository,
            IProductReadRepository productReadRepository)
        {
            _variantItemReadRepository = variantItemReadRepository;
            _classificationAttributeValueService = classificationAttributeValueService;
            _variantValueReadRepository = variantValueReadRepository;
            _variantItemWriteRepository = variantItemWriteRepository;
            _productReadRepository = productReadRepository;
            _mediaService = mediaService;
            _mediaFormatReadRepository = mediaFormatReadRepository;
            _mapper = mapper;
        }
        public async Task<VariantItem> Save(VariantItemDto variantItemDto)
        {
            VariantItem variantItem = new();
            variantItem.Name = variantItemDto.Name;
            variantItem.Code = Guid.NewGuid().ToString();
            variantItem.Price = variantItemDto.Price != null ? (decimal)variantItemDto.Price : 0;
            variantItem.DiscountedPrice = variantItemDto.DiscountedPrice!=null ? (decimal)variantItemDto.DiscountedPrice : 0;
            variantItem.Barcode = variantItemDto.Barcode;

            var variantValues = new HashSet<VariantValue>();
            foreach (var item in variantItemDto.VariantValues)
            {
                var variantValue = _variantValueReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefault();
                variantValues.Add(variantValue);
            }
            variantItem.VariantValues = variantValues;

            var classificationAttributeValues = new HashSet<ClassificationAttributeValue>();
            foreach (var item in variantItemDto.ClassificationAttributeValues)
            {
                var classificationAttributeValue = await _classificationAttributeValueService.Save(item);
                classificationAttributeValues.Add(classificationAttributeValue);
            }
            variantItem.ClassificationAttributeValues = classificationAttributeValues;

            var galleries = new HashSet<Gallery>();
            var mediaFormats = await _mediaFormatReadRepository
                .GetWhere(x => x.MediaFormatType==MediaFormatType.PRODUCT || x.MediaFormatType==MediaFormatType.ALL).ToListAsync();
            Parallel.ForEach(variantItemDto.Files, item =>
            {
                var model = _mediaService.SaveGalleryForBinary(item, mediaFormats, true);
                galleries.Add(model);
            });
            variantItem.Galleries = galleries;

            var model = await _variantItemWriteRepository.AddAsyncWithModel(variantItem);
            return model;

        }

        public async Task<VariantItem> Update(VariantItemDto variantItemDto, ICollection<Gallery>? modelGalleries, ICollection<ClassificationAttributeValue>? modelClassificationAttributeValues)
        {
            VariantItem variantItem = new();
            variantItem.Id = variantItemDto.Id;
            variantItem.Name = variantItemDto.Name;
            variantItem.Code = variantItemDto.Code;
            variantItem.Price = variantItemDto.Price != null ? (decimal)variantItemDto.Price : 0;
            variantItem.DiscountedPrice = variantItemDto.DiscountedPrice != null ? (decimal)variantItemDto.DiscountedPrice : 0;
            variantItem.Barcode = variantItemDto.Barcode;

            var variantValues = new HashSet<VariantValue>();
            foreach (var item in variantItemDto.VariantValues)
            {
                var variantValue = _variantValueReadRepository.GetWhere(x => x.Code == item.Code).FirstOrDefault();
                variantValues.Add(variantValue);
            }
            variantItem.VariantValues = variantValues;

            var classificationAttributeValues = new HashSet<ClassificationAttributeValue>();
            foreach (var item in variantItemDto.ClassificationAttributeValues)
            {
                if (modelClassificationAttributeValues.Select(x => x.Code).Any(x => x == item.Code))
                {
                    var modifiedClassificationattributeValue = await _classificationAttributeValueService.Update(item);
                    classificationAttributeValues.Add(modifiedClassificationattributeValue);
                }
                else
                {
                    var classificationAttributeValue = await _classificationAttributeValueService.Save(item);
                    classificationAttributeValues.Add(classificationAttributeValue);
                }
            }
            var notContainsClassificationAttributeValueModel = modelClassificationAttributeValues
                .Select(x => x.Code).Where(x => !variantItemDto.ClassificationAttributeValues.Select(x => x.Code).Contains(x)).ToList();
            foreach (var item in notContainsClassificationAttributeValueModel)
            {
                await _classificationAttributeValueService.Delete(item);
            }
            variantItem.ClassificationAttributeValues = classificationAttributeValues;

            var galleries = new HashSet<Gallery>();
            foreach (var item in modelGalleries)
            {
                if (!(variantItemDto.Galleries.Select(x => x.Code).Any(x => x == item.Code)))
                {
                   await _mediaService.DeleteGallery(item.Code);
                }
            }
           
            var mediaFormats = await _mediaFormatReadRepository
                .GetWhere(x => x.MediaFormatType==MediaFormatType.PRODUCT || x.MediaFormatType==MediaFormatType.ALL).ToListAsync();
            if (variantItemDto.Files != null)
            {
                foreach (var item in variantItemDto.Files)
                {
                    var media = _mediaService.SaveGalleryForBinary(item,mediaFormats, true);
                    galleries.Add(media);
                }
            }
            variantItem.Galleries = galleries;

            var model = await _variantItemWriteRepository.UpdateAsyncWithModel(variantItem, variantItemDto.Id);
            return model;
        }
    }
}
