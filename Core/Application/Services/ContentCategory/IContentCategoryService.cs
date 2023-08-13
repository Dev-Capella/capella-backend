using Application.DataTransferObject;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ContentCategory
{
    public interface IContentCategoryService
    {
     
        Task Save(ContentCategoryDto contentCategoryDto);
        Task<ContentCategoryDto> GetContentCategoryByCode(string code);
        Task Update(ContentCategoryDto contentCategoryDto);
        Task Delete(string code);
        Task<List<ContentCategoryDto>> GetAllContentCategories();

    }
}
