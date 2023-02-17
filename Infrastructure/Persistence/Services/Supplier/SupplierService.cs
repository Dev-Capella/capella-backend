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
    public class SupplierService: ISupplierService
    {
        private readonly ISupplierReadRepository _supplierReadRepository;
        private readonly ISupplierWriteRepository _supplierWriteRepository;
        private readonly IMapper _mapper;

        public SupplierService(ISupplierReadRepository supplierReadRepository, ISupplierWriteRepository supplierWriteRepository, IMapper mapper)
        {
            _supplierReadRepository = supplierReadRepository;
            _supplierWriteRepository = supplierWriteRepository;
            _mapper = mapper;
        }

        public async Task Delete(string code)
        {
            var supplier = await _supplierReadRepository.GetWhere(x => x.Code == code).FirstOrDefaultAsync();
            await _supplierWriteRepository.RemoveAsync(supplier);
        }

        public async Task<List<SupplierDto>> GetAllSuppliers()
        {
            var suppliers = await _supplierReadRepository.GetAll().ToListAsync();
            var supplierDto = _mapper.Map<List<SupplierDto>>(suppliers);
            return supplierDto;
        }

        public async Task<SupplierDto> GetSupplierByCode(string code)
        {
            var supplier = await _supplierReadRepository.GetWhere(x => x.Code == code).FirstOrDefaultAsync();
            var supplierDto = _mapper.Map<SupplierDto>(supplier);
            return supplierDto;
        }

        public async Task Save(SupplierDto supplierDto)
        {
            Supplier supplier = new();
            supplier.Code = Guid.NewGuid().ToString();
            supplier.Name = supplierDto.Name;
            supplier.Email = supplierDto.Email;
            supplier.Telephone = supplierDto.Telephone;
            supplier.Company = supplierDto.Company;
            supplier.EmployeeName = supplierDto.EmployeeName;
            supplier.TaxNumber = supplierDto.TaxNumber;
            supplier.Address = supplierDto.Address;
            await _supplierWriteRepository.AddAsync(supplier);

        }

        public async Task Update(SupplierDto supplierDto)
        {
            var supplier = await _supplierReadRepository.GetWhere(x => x.Code == supplierDto.Code).FirstOrDefaultAsync();
            supplier.Code = supplierDto.Code;
            supplier.Name = supplierDto.Name;
            supplier.Email = supplierDto.Email;
            supplier.Telephone = supplierDto.Telephone;
            supplier.Company = supplierDto.Company;
            supplier.EmployeeName = supplierDto.EmployeeName;
            supplier.TaxNumber = supplierDto.TaxNumber;
            supplier.Address = supplierDto.Address;
            await _supplierWriteRepository.UpdateAsync(supplier, supplier.Id);
        }


    }
}
