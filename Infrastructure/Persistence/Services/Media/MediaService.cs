using Application.DataTransferObject;
using Application.Repositories;
using Application.Services;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Bmp;
using SixLabors.ImageSharp.Formats.Gif;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Tiff;
using SixLabors.ImageSharp.Processing;

namespace Persistence.Services
{

    public class MediaService : IMediaService
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private readonly IConfiguration _config;
        private readonly IMediaWriteRepository _mediaWriteRepository;
        private readonly IGalleryWriteRepository _galleryWriteRepository;
        private readonly IGalleryReadRepository _galleryReadRepository;
        private readonly IMediaFormatReadRepository _mediaFormatReadRepository;
        public MediaService(IConfiguration config, 
            IMediaWriteRepository mediaWriteRepository, 
            IMediaFormatReadRepository mediaFormatReadRepository,
            IGalleryWriteRepository galleryWriteRepository,
            IGalleryReadRepository galleryReadRepository)
        {
            _config = config;
            _mediaWriteRepository = mediaWriteRepository;
            _mediaFormatReadRepository = mediaFormatReadRepository;
            _galleryReadRepository = galleryReadRepository;
            _galleryWriteRepository = galleryWriteRepository;
        }
        public async Task<Media> Storage(IFormFile formFile, bool secure)
        { 
            
            try
            {
                var todayDate = DateTime.Now.ToString("yyyyMMdd");
                var todayTime = DateTime.Now.ToString("HHmmss");
                var rootPath = _config["MediaStorage:FileRootPath"];
                var isSecure = secure ? _config["MediaStorage:SecurePath"] : _config["MediaStorage:PublicPath"];
                var filePath = $"{isSecure}capella/{todayDate}/{todayTime}";
                var fullPath = $"{rootPath}/{filePath}";        
                var filenamehash =  new string(Enumerable.Repeat(chars, 20).Select(s => s[random.Next(s.Length)]).ToArray());

                Directory.CreateDirectory(fullPath);
                using (var stream = new FileStream(Path.Combine(fullPath, formFile.FileName), FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                Media media = new();
                media.RealFilename = formFile.FileName;
                media.EncodedFilename = filenamehash;
                media.Extension = Path.GetExtension(formFile.FileName);
                media.FilePath = filePath;
                media.RootPath = rootPath;
                media.Size = formFile.Length;
                media.Mime = formFile.ContentType;
                media.Secure = secure;
                var absolutePath = $"{filePath}/{filenamehash}{Path.GetExtension(formFile.FileName)}";
                media.AbsolutePath = absolutePath;
                media.ServePath = absolutePath;
                media.Code = Guid.NewGuid().ToString();
                await _mediaWriteRepository.AddAsync(media);
                return media;
                
            }
            catch (IOException exception)
            {

                throw exception;
            }
        }

        public async Task<Gallery> SaveGallery(IFormFile formFile, bool secure)
        {
            try
            {
                Gallery gallery = new Gallery();
                var todayDate = DateTime.Now.ToString("yyyyMMdd");
                var todayTime = DateTime.Now.ToString("HHmmss");
                var isSecure = secure ? _config["MediaStorage:SecurePath"] : _config["MediaStorage:PublicPath"];
                var rootPath = _config["MediaStorage:FileRootPath"];
                var servePath = _config["MediaStorage:ServePath"];
                var filePath = $"{isSecure}capella/{todayDate}/{todayTime}";
                var fullPath = $"{rootPath}/{filePath}";
                Directory.CreateDirectory(fullPath);
                gallery.Code = Guid.NewGuid().ToString();
                gallery.Name = formFile.FileName;

                var mediaFormats = _mediaFormatReadRepository.GetAll().ToList();
                var medias = new HashSet<Media>();
                foreach (var mediaFormat in mediaFormats)
                {
                    
                    var filenamehash = new string(Enumerable.Repeat(chars, 20).Select(s => s[random.Next(s.Length)]).ToArray());
                   
                    using (var stream = new MemoryStream())
                    {
                        await formFile.CopyToAsync(stream);
                        stream.Position = 0;
                        string fileName = Path.Combine(fullPath, filenamehash +"-"+mediaFormat.Name+Path.GetExtension(formFile.FileName));
                        using (var image = Image.Load(stream))
                        {
                            var options = new ResizeOptions
                            {
                                Size = new Size(mediaFormat.Height??0, mediaFormat.Width??0),
                                Mode = ResizeMode.Max
                            };

                            image.Mutate(x => x.Resize(options));

                            using (var output = File.OpenWrite(fileName))
                            {
                                image.Save(output, GetEncoder(fileName));
                            }
                        }


                    }

                    Media media = new();
                    media.RealFilename = formFile.FileName;
                    media.EncodedFilename = filenamehash;
                    media.Extension = Path.GetExtension(formFile.FileName);
                    media.FilePath = filePath;
                    media.RootPath = rootPath;
                    media.Size = formFile.Length;
                    media.Mime = formFile.ContentType;
                    media.Secure = secure;
                    var absolutePath = $"{servePath}{filePath}/{filenamehash}{Path.GetExtension(formFile.FileName)}";
                    media.AbsolutePath = absolutePath;
                    media.ServePath = absolutePath;
                    media.Code = Guid.NewGuid().ToString();
                    await _mediaWriteRepository.AddAsync(media);
                    medias.Add(media);

                }
                gallery.Medias = medias;
                return gallery;
            }
            catch (IOException exception)
            {
                throw exception;
            }
        }


        public async Task<Gallery> SaveGalleryForBinary(FileDto fileDto, MediaFormatType mediaFormatType, bool secure)
        {
            try
            {
                Gallery gallery = new Gallery();
                var todayDate = DateTime.Now.ToString("yyyyMMdd");
                var todayTime = DateTime.Now.ToString("HHmmss");
                var isSecure = secure ? _config["MediaStorage:SecurePath"] : _config["MediaStorage:PublicPath"];
                var rootPath = _config["MediaStorage:FileRootPath"];
                var servePath = _config["MediaStorage:ServePath"];
                var filePath = $"{isSecure}capella/{todayDate}/{todayTime}";
                var fullPath = $"{rootPath}/{filePath}";
                Directory.CreateDirectory(fullPath);
                gallery.Code = Guid.NewGuid().ToString();
                gallery.Name = fileDto.FileName;

                var mediaFormats = await _mediaFormatReadRepository
                    .GetWhere(x => x.MediaFormatType==mediaFormatType).ToListAsync();
                var medias = new HashSet<Media>();
                foreach (var mediaFormat in mediaFormats)
                {
                    var filenamehash = new string(Enumerable.Repeat(chars, 20).Select(s => s[random.Next(s.Length)]).ToArray());
                    var imageBytes = Convert.FromBase64String(fileDto.File);
                    using (var stream = new MemoryStream(imageBytes))
                    {

                        stream.Position = 0;
                      
                        var fileName = Path.Combine(fullPath, filenamehash + "-" + mediaFormat.Name+Path.GetExtension(fileDto.FileName));
                       
                        using (var image = Image.Load(stream))
                        {
                            if (mediaFormat.Code != "original")
                            {
                               
                                var options = new ResizeOptions
                                {
                                    Size = new Size(mediaFormat.Height ?? 0, mediaFormat.Width ?? 0),
                                    Mode = ResizeMode.Max
                                };
                               
                                image.Mutate(x => x.Resize(options));
                               
                            }

                            using (var output = File.OpenWrite(fileName))
                            {
                               
                                image.Save(output, GetEncoder(fileName));
                            }
                        }
                    }

                    Media media = new();
                    media.RealFilename = fileDto.FileName;
                    media.MediaFormat = await _mediaFormatReadRepository.GetWhere(x => x.Code == mediaFormat.Code).FirstOrDefaultAsync();
                    media.EncodedFilename = filenamehash;
                    media.Extension = Path.GetExtension(fileDto.FileName);
                    media.FilePath = filePath;
                    media.RootPath = rootPath;
                    media.Size = fileDto.Length;
                    media.Mime = fileDto.ContentType;
                    media.Secure = secure;
                    var absolutePath = $"{filePath}/{filenamehash}-{mediaFormat.Name}{Path.GetExtension(fileDto.FileName)}";
                    media.AbsolutePath = absolutePath;
                    media.ServePath = absolutePath;
                    media.Code = Guid.NewGuid().ToString();
                    await _mediaWriteRepository.AddAsync(media);
                    medias.Add(media);

                }
                gallery.Medias = medias;
                return gallery;
            }
            catch (IOException exception)
            {
                throw exception;
            }
        }


        private static IImageEncoder GetEncoder(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            switch (extension)
            {
                case ".bmp":
                    return new BmpEncoder();
                case ".gif":
                    return new GifEncoder();
                case ".jpg":
                case ".jpeg":
                    return new JpegEncoder();
                case ".png":
                    return new PngEncoder();
                case ".tiff":
                    return new TiffEncoder();
                default:
                    throw new NotSupportedException($"The specified file extension is not supported: {extension}");
            }
        }

        public async Task DeleteGallery(string code)
        {
            var gallery = await _galleryReadRepository.GetWhere(x => x.Code == code).Include(x=>x.Medias).FirstOrDefaultAsync();
            foreach (var item in gallery.Medias)
            {
                item.Deleted = true;
                _mediaWriteRepository.UpdateAsync(item, item.Id);
            }
           
        }

        public string GenerateMediaUrl(string url)
        {
            var servePath = _config["MediaStorage:ServePath"];
            return String.Concat(servePath, url);
        }
    }


}
