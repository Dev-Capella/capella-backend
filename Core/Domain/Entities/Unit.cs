﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Unit : CodeBaseEntity
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }

    }
}
