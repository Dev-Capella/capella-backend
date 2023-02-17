using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City: CodeBaseEntity
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}
