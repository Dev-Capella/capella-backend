using Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ISupplierService
    {
        Task Save(SupplierDto supplierDto);
        Task<SupplierDto> GetSupplierByCode(string code);
        Task Update(SupplierDto brandDto);
        Task Delete(string code);
        Task<List<SupplierDto>> GetAllSuppliers();
    }
}
