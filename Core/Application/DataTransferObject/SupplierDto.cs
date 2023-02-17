using Application.DataTransferObject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class SupplierDto : BaseDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public string? Company { get; set; }
        public string? EmployeeName { get; set; }
        public string? TaxNumber { get; set; }
        public string? Address { get; set; }
    }
}
