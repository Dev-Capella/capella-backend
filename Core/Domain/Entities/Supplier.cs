using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Supplier: CodeBaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string Company { get; set; }

        public string EmployeeName { get; set; }

        public string TaxNumber { get; set; }

        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
