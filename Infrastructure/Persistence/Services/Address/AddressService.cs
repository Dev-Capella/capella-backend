using Application.DataTransferObject;
using Application.Repositories;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressReadRepository _addressReadRepository;
        private readonly IAddressWriteRepository _addressWriteRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly ICountryReadRepository _countryReadRepository;
        private readonly ICityReadRepository _cityReadRepository;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly IMapper _mapper;

        public AddressService(
            IAddressReadRepository addressReadRepository, 
            IAddressWriteRepository addressWriteRepository, 
            IUserReadRepository userReadRepository,
            ICountryReadRepository countryReadRepository,
            ICityReadRepository cityReadRepository,
            IDistrictReadRepository districtReadRepository,
            IMapper mapper)
        {
            _addressReadRepository = addressReadRepository;
            _addressWriteRepository = addressWriteRepository;
            _userReadRepository = userReadRepository;
            _countryReadRepository = countryReadRepository;
            _cityReadRepository = cityReadRepository;
            _districtReadRepository = districtReadRepository;
            _mapper = mapper;
        }

        public async Task<List<CountryDto>> GetAllCountries()
        {
            var countries = await _countryReadRepository.GetAll().ToListAsync();
            var countryDto = _mapper.Map<List<CountryDto>>(countries);
            return countryDto;
        }

        public async Task<List<CityDto>> GetCitiesByCountryCode(string code)
        {
            var cities = await _cityReadRepository.GetWhere(x => x.Country.Code == code).ToListAsync();
            var cityDto = _mapper.Map< List<CityDto>>(cities);
            return cityDto;
        }

        public async Task<List<DistrictDto>> GetDistrictsByCityCode(string code)
        {
            var districts = await _districtReadRepository.GetWhere(x => x.City.Code == code).ToListAsync();
            var districDto = _mapper.Map<List<DistrictDto>>(districts);
            return districDto;
        }
        public async Task Save(AddressDto addressDto)
        {
            Address address = new();
            address.Name = addressDto.Name;
            address.Firstname = addressDto.Firstname;
            address.Lastname = addressDto.Lastname;
            address.PhoneNumber = addressDto.PhoneNumber;
            address.City = addressDto.City;
            address.District = addressDto.District;
            address.Neighbourhood = addressDto.Neighbourhood;
            address.FullAddress = addressDto.FullAddress;
            address.User = _userReadRepository.GetWhere(u=> u.Username == addressDto.UserDto.Username).FirstOrDefault();
            await _addressWriteRepository.AddAsync(address);   
        }
    }
}
