﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class MediaFormat: CodeBaseEntity
    {
        public string Name { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }

        public MediaFormatType MediaFormatType { get; set; }
        public ICollection<Media> Medias { get; set; }
    }
}
