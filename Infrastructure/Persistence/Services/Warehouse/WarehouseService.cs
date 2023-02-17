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
    public class WarehouseService: IWarehouseService
    {
        private readonly IWarehouseReadRepository _warehouseReadRepository;
        private readonly IWarehouseWriteRepository _warehouseWriteRepository;
        private readonly ICountryReadRepository _countryReadRepository;
        private readonly ICityReadRepository _cityReadRepository;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly IMapper _mapper;

        public WarehouseService(IWarehouseReadRepository warehouseReadRepository,
            IWarehouseWriteRepository warehouseWriteRepository,
            ICountryReadRepository countryReadRepository,
            ICityReadRepository cityReadRepository,
            IDistrictReadRepository districtReadRepository,
            IMapper mapper)
        {
            _warehouseReadRepository = warehouseReadRepository;
            _warehouseWriteRepository = warehouseWriteRepository;
            _countryReadRepository = countryReadRepository;
            _districtReadRepository = districtReadRepository;
            _cityReadRepository = cityReadRepository;
            _mapper = mapper;
        }

        public async Task Delete(string code)
        {
            var warehouse = await _warehouseReadRepository.GetWhere(x => x.Code == code).FirstOrDefaultAsync();
            await _warehouseWriteRepository.RemoveAsync(warehouse);
        }

        public async Task<List<WarehouseDto>> GetAllWarehouses()
        {
            var warehouses = await _warehouseReadRepository.GetAll().ToListAsync();
            var warehouseDto = _mapper.Map<List<WarehouseDto>>(warehouses);
            return warehouseDto;
        }

        public async Task<WarehouseDto> GetWarehouseByCode(string code)
        {
            var warehouse = await _warehouseReadRepository.GetWhere(x => x.Code == code).FirstOrDefaultAsync();
            var warehouseDto = _mapper.Map<WarehouseDto>(warehouse);
            return warehouseDto;
        }

        public async Task Save(WarehouseDto warehouseDto)
        {
            Warehouse warehouse = new();
            warehouse.Code = Guid.NewGuid().ToString();
            warehouse.Name = warehouseDto.Name;
            warehouse.Telephone = warehouseDto.Telephone;
            warehouse.OpenAdress = warehouseDto.OpenAdress;
            warehouse.PostCode = warehouseDto.PostCode;
            var country = await _countryReadRepository.GetWhere(x => x.Code == warehouseDto.Country.Code).FirstOrDefaultAsync();
            warehouse.Country = country;
            var city = await _cityReadRepository.GetWhere(x => x.Code == warehouseDto.City.Code).FirstOrDefaultAsync();
            warehouse.City = city;
            var district = await _districtReadRepository.GetWhere(x => x.Code == warehouseDto.District.Code).FirstOrDefaultAsync();
            warehouse.District = district;
            await _warehouseWriteRepository.AddAsync(warehouse);

        }

        public async Task Update(WarehouseDto warehouseDto)
        {
            var warehouse = await _warehouseReadRepository.GetWhere(x => x.Code == warehouseDto.Code)
                .Include(x=> x.Country)
                .Include(x => x.City)
                .Include(x=> x.District)
                .FirstOrDefaultAsync();
            warehouse.Code = warehouseDto.Code;
            warehouse.Name = warehouseDto.Name;
            warehouse.Telephone = warehouseDto.Telephone;
            warehouse.OpenAdress = warehouseDto.OpenAdress;
            warehouse.PostCode = warehouseDto.PostCode;
            var country = await _countryReadRepository.GetWhere(x => x.Code == warehouseDto.Country.Code).FirstOrDefaultAsync();
            warehouse.Country = country;
            var city = await _cityReadRepository.GetWhere(x => x.Code == warehouseDto.City.Code).FirstOrDefaultAsync();
            warehouse.City = city;
            var district = await _districtReadRepository.GetWhere(x => x.Code == warehouseDto.District.Code).FirstOrDefaultAsync();
            warehouse.District = district;
            await _warehouseWriteRepository.UpdateAsync(warehouse, warehouse.Id);
        }

    }
}
