using Application.DataTransferObject;
using Application.Repositories;
using Application.Services;
using Application.Services.Banner;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Persistence.Services
{
    public class BannerService: IBannerService
    {
        private readonly IBannerReadRepository _bannerReadRepository;
        private readonly IBannerWriteRepository _bannerWriteRepository;
        private readonly IMediaService _mediaService;
        private readonly IMediaFormatReadRepository _mediaFormatReadRepository;
        private readonly IMapper _mapper;

        public BannerService(
            IBannerReadRepository bannerReadRepository, 
            IBannerWriteRepository bannerWriteRepository, 
            IMediaService mediaService,
            IMediaFormatReadRepository mediaFormatReadRepository,
            IMapper mapper)
        {
            _bannerReadRepository = bannerReadRepository;
            _bannerWriteRepository = bannerWriteRepository;
            _mediaService = mediaService;
            _mediaFormatReadRepository = mediaFormatReadRepository;
            _mapper = mapper;
        }

        public async Task Delete(string code)
        {
            var banner = await _bannerReadRepository.GetWhere(x => x.Code == code).FirstOrDefaultAsync();
            await _bannerWriteRepository.RemoveAsync(banner);
        }

        public async Task<List<BannerDto>> GetAllBanners()
        {
            var banners = await _bannerReadRepository.GetAllWithIncludeStringParam(true,"Gallery.Medias.MediaFormat").ToListAsync();
            var bannerDto = _mapper.Map<List<BannerDto>>(banners);
            return bannerDto;
        }

        public async Task<BannerDto> GetBannerByCode(string code)
        {
            var banner = await _bannerReadRepository.GetWhere(x => x.Code == code)
                .Include(x=> x.Gallery)
                .ThenInclude(galleries => galleries.Medias.Where(m => m.MediaFormat.Code == "original")).FirstOrDefaultAsync();
            var bannerDto = _mapper.Map<BannerDto>(banner);
            return bannerDto;
        }

        public async Task Save(BannerDto bannerDto)
        {
            Banner banner = new();
            banner.Code = Guid.NewGuid().ToString();
            banner.Name = bannerDto.Name;
            banner.Description = bannerDto.Description;
            banner.Text = bannerDto.Text;
            banner.Link = bannerDto.Link;
            banner.Active = bannerDto.Active;
            banner.BannerType = bannerDto.BannerType;
            var mediaType = GetMediaFormatTypeByBannerType(bannerDto.BannerType);
            var mediaFormats = await _mediaFormatReadRepository
                .GetWhere(x => x.MediaFormatType==mediaType || x.MediaFormatType==MediaFormatType.ALL).ToListAsync();
            var gallery =  _mediaService.SaveGalleryForBinary(bannerDto.File, mediaFormats,true);
            banner.Gallery = gallery;
            await _bannerWriteRepository.AddAsync(banner);
        }

        public async Task Update(BannerDto bannerDto)
        {
            var banner = await _bannerReadRepository.GetWhere(x => x.Code == bannerDto.Code).Include(x => x.Gallery).FirstOrDefaultAsync();
            banner.Code = bannerDto.Code;
            banner.Name = bannerDto.Name;
            banner.Description = bannerDto.Description;
            banner.Text = bannerDto.Text;
            banner.Link = bannerDto.Link;
            banner.BannerType = bannerDto.BannerType;
            var mediaType = GetMediaFormatTypeByBannerType(bannerDto.BannerType);
            if (banner.Gallery == null)
            {
                await _mediaService.DeleteGallery(banner.Gallery.Code);  
            }
            var mediaFormats = await _mediaFormatReadRepository
                .GetWhere(x => x.MediaFormatType==mediaType || x.MediaFormatType==MediaFormatType.ALL).ToListAsync();
            if (bannerDto.File != null)
            {
                var gallery = _mediaService.SaveGalleryForBinary(bannerDto.File, mediaFormats,true);
                banner.Gallery = gallery;  
            }
            await _bannerWriteRepository.UpdateAsync(banner, bannerDto.Id);
        }

        private MediaFormatType GetMediaFormatTypeByBannerType(BannerType bannerType)
        {
            switch (bannerType)
            {
                case BannerType.TOP:
                    return MediaFormatType.TOPBANNER;
                case BannerType.CARD:
                    return MediaFormatType.CARDBANNER;
                case BannerType.CAROUSEL:
                    return MediaFormatType.CAROUSELBANNER;
                default:
                    throw new NotSupportedException("Unsupported banner type");
            }
        }
        
    }
}
