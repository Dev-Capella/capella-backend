using Application.DataTransferObject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.DataTransferObject
{
    public class BannerDto: BaseDto
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public bool Active { get; set; }
        public BannerType BannerType { get; set; }
        public FileDto File { get; set; }
        
        public GalleryDto? Gallery { get; set; }
    }
}
