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
        Task<Media> Storage(IFormFile formFile, bool secure);

        Task<Gallery> SaveGallery(IFormFile formFile, bool secure);

        Task<Gallery> SaveGalleryForBinary(FileDto fileDto, MediaFormatType mediaFormatType, bool secure);
        Task DeleteGallery(string code);

        string GenerateMediaUrl(string url);
    }
}
