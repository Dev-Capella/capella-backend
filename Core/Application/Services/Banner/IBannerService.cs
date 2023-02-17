using Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Banner
{
    public interface IBannerService
    {
        Task Save(BannerDto bannerDto);
        Task<BannerDto> GetBannerByCode(string code);
        Task Update(BannerDto bannerDto);
        Task Delete(string code);
        Task<List<BannerDto>> GetAllBanners();
    }
}
