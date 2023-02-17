using Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IWarehouseService
    {
        Task Save(WarehouseDto warehouseDto);
        Task<WarehouseDto> GetWarehouseByCode(string code);
        Task Update(WarehouseDto warehouseDto);
        Task Delete(string code);
        Task<List<WarehouseDto>> GetAllWarehouses();
    }
}
