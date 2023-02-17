using Application.DataTransferObject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class WarehouseDto: BaseDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Telephone { get; set; }
        public string? OpenAdress { get; set; }
        public string? PostCode { get; set; }
        public CountryDto? Country { get; set; }
        public CityDto? City { get; set; }
        public DistrictDto? District { get; set; }
    }
}
