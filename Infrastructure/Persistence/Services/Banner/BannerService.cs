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

namespace Persistence.Services
{
    public class BannerService: IBannerService
    {
        private readonly IBannerReadRepository _bannerReadRepository;
        private readonly IBannerWriteRepository _bannerWriteRepository;
        private readonly IMediaService _mediaService;
        private readonly IMapper _mapper;

        public BannerService(
            IBannerReadRepository bannerReadRepository, 
            IBannerWriteRepository bannerWriteRepository, 
            IMediaService mediaService,
            IMapper mapper)
        {
            _bannerReadRepository = bannerReadRepository;
            _bannerWriteRepository = bannerWriteRepository;
            _mediaService = mediaService;
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
            var banner = await _bannerReadRepository.GetWhere(x => x.Code == code).FirstOrDefaultAsync();
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
            var gallery = await _mediaService.SaveGalleryForBinary(bannerDto.File, true);
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
            if (banner.Gallery == null)
            {
                await _mediaService.DeleteGallery(banner.Gallery.Code);  
            }

            if (bannerDto.File != null)
            {
                var gallery = await _mediaService.SaveGalleryForBinary(bannerDto.File, true);
                banner.Gallery = gallery;  
            }
            await _bannerWriteRepository.UpdateAsync(banner, bannerDto.Id);
        }
    }
}
