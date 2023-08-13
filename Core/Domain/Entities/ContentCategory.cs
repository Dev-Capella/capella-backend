﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ContentCategory : CodeBaseEntity
    {
       public string Name { get; set; } 
       public ICollection<Media> Medias { get; set; }
  
    }
}
