using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class District: CodeBaseEntity
    {
        public string Name { get; set; }
        public City City { get; set; }
    }
}
