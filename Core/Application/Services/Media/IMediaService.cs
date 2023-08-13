using Application.DataTransferObject;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Services
{
    public interface IMediaService
    {
        Task<List<MediaDto>> Save(List<IFormFile> formfiles, string contentCategoryCode, bool secure);
        Task<Media> Storage(IFormFile formFile, bool secure);

        Task<Gallery> SaveGallery(IFormFile formFile, bool secure);

        Gallery SaveGalleryForBinary(FileDto fileDto, IEnumerable<MediaFormat> mediaFormats, bool secure);
        Task DeleteGallery(string code);

        string GenerateMediaUrl(string url);
    }
}
