using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class Banner: CodeBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public bool Active { get; set; }
        
        public BannerType BannerType { get; set; }
        public Gallery Gallery { get; set; }
    }
}
