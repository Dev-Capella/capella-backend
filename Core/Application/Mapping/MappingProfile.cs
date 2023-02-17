using Application.DataTransferObject;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class MappingProfile : Profile
    {
        private readonly IMediaService _mediaService;
        public MappingProfile(IMediaService mediaService)
        {
            _mediaService = mediaService;
            #region Product Mapper

            CreateMap<Product, ProductListDto>()
             .ForMember(dto => dto.Galleries, opt => opt.MapFrom(src =>
                 src.VariantItems.Any()
                     ? new HashSet<Gallery> { src.VariantItems.First().Galleries.Select(x => new Gallery {
                         Id = x.Id,
                         Code = x.Code,
                         Name = x.Name,
                         Medias = x.Medias.Where(m => m.MediaFormat.Code == "icon" || m.MediaFormat.Code =="superzoom").ToList()
                     }).FirstOrDefault() }
                     : src.Galleries.Count>0 ? new HashSet<Gallery> {src.Galleries.Select(x => new Gallery
                     {
                         Id = x.Id,
                         Code = x.Code,
                         Name = x.Name,
                         Medias = x.Medias.Where(m => m.MediaFormat.Code == "icon" || m.MediaFormat.Code =="superzoom").ToList()
                     }).FirstOrDefault() } : new HashSet<Gallery>()
                     ));
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Classifications, opt => opt.MapFrom(src => src.ClassificationAttributeValues.Select(cav => cav.Classification).Select(c => new Classification
                {
                    Code = c.Code,
                    CreatedDate = c.CreatedDate,
                    LastModifiedDate = c.LastModifiedDate,
                    Id = c.Id,
                    Name = c.Name,
                    DataType = c.DataType,
                    Options = c.Options.OrderBy(o => o.Id).ToList()
                }).ToList()))
                .ReverseMap();
            #endregion

            #region Category Mapper

            CreateMap<Category, CategoryDto>().ReverseMap();
            //CreateMap<Category[], CategoryDto[]>().ReverseMap();

            #endregion

            #region Classification Mapper
            CreateMap<Classification, ClassificationDto>().ReverseMap();
            #endregion

            #region Unit Mapper

            CreateMap<Unit, UnitDto>().ReverseMap();

            #endregion

            #region User Mapper
            CreateMap<User, UserDto>().ReverseMap();
            #endregion

            #region Role Mapper
            CreateMap<Role, RoleDto>().ReverseMap();
            #endregion

            #region Permission Mapper
            CreateMap<Permission, PermissionDto>().ReverseMap();
            #endregion

            #region Media Mapper
            CreateMap<Media, MediaDto>()
                  .ForMember(dest => dest.AbsolutePath, opt => opt.MapFrom(src => _mediaService.GenerateMediaUrl(src.AbsolutePath)))
                .ReverseMap();
            #endregion

            #region Gallery Mapper
            CreateMap<Gallery, GalleryDto>().ReverseMap();
            #endregion

            #region MediaFormat Mapper
            CreateMap<MediaFormat, MediaFormatDto>().ReverseMap();
            #endregion

            #region ClassificationAttributeValue Mapper
            CreateMap<ClassificationAttributeValue, ClassificationAttributeValueDto>().ReverseMap();
            #endregion

            #region Options Mapper
            CreateMap<Options, OptionsDto>().ReverseMap();
            #endregion

            #region Variant Mapper
            CreateMap<Variant, VariantDto>().ReverseMap();
            #endregion

            #region VariantValue Mapper
            CreateMap<VariantValue, VariantValueDto>().ReverseMap();
            #endregion

            #region VariantItem Mapper
            CreateMap<VariantItem, VariantItemDto>()
                .ForMember(dest => dest.Classifications, opt => opt.MapFrom(src => src.ClassificationAttributeValues.Select(cav => cav.Classification).Select(c => new Classification
                {
                    Code = c.Code,
                    CreatedDate = c.CreatedDate,
                    LastModifiedDate = c.LastModifiedDate,
                    Id = c.Id,
                    Name = c.Name,
                    DataType = c.DataType,
                    Options = c.Options.OrderBy(o => o.Id).ToList()
                }).ToList()))
                .ReverseMap();
            #endregion

            #region Brand Mapper
            CreateMap<Brand, BrandDto>().ReverseMap();
            #endregion

            #region Tag Mapper
            CreateMap<Tag, TagDto>().ReverseMap();
            #endregion

            #region Supplier Mapper
            CreateMap<Supplier, SupplierDto>().ReverseMap();
            #endregion

            #region Country Mapper
            CreateMap<Country, CountryDto>().ReverseMap();
            #endregion

            #region City Mapper
            CreateMap<City, CityDto>().ReverseMap();
            #endregion

            #region District Mapper
            CreateMap<District, DistrictDto>().ReverseMap();
            #endregion

            #region Banner Mapper
            CreateMap<Banner, BannerDto>().ReverseMap();
            #endregion

        }
    }
}
