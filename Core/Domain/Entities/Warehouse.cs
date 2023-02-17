using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Warehouse: CodeBaseEntity
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string OpenAdress { get; set; }
        public string PostCode { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public District District { get; set; }
    }
}
