﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class GalleryDto
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public bool Active { get; set; }
        public ICollection<MediaDto>? Medias { get; set; }
    }
}
