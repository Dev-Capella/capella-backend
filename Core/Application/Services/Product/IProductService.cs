using Application.DataTransferObject;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IProductService
    {
        Task Save(ProductDto productDto);
        Task<List<ProductListDto>> GetAllProducts();
        Task Delete(string code);
        Task Update(ProductDto productDto);
        Task<ProductDto> GetProductByCode(string code);
    }
}
