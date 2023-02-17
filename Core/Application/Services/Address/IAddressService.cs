using Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IAddressService
    {
        Task Save(AddressDto addressDto);
        Task<List<CountryDto>> GetAllCountries();
        Task<List<CityDto>> GetCitiesByCountryCode(string code);
        Task<List<DistrictDto>> GetDistrictsByCityCode(string code);
    }
}
