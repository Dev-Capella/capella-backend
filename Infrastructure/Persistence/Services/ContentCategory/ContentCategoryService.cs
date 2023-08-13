using Application.DataTransferObject;
using Application.Repositories;
using Application.Services.ContentCategory;
using AutoMapper;
using Domain.Entities;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class ContentCategoryService : IContentCategoryService
    {
        private readonly IContentCategoryReadRepository _contentCategoryReadRepository;
        private readonly IContentCategoryWriteRepository _contentCategoryWriteRepository;
        private readonly IMapper _mapper;
        public ContentCategoryService(IContentCategoryReadRepository contentCategoryReadRepository, IContentCategoryWriteRepository contentCategoryWriteRepository,IMapper mapper)
        {

            _contentCategoryReadRepository = contentCategoryReadRepository;
            _contentCategoryWriteRepository = contentCategoryWriteRepository;
            _mapper = mapper;   

        }


        public async Task Delete(string code)
        {
            var contentCategory = _contentCategoryReadRepository.GetWhere(x => x.Code == code).FirstOrDefault();
            await _contentCategoryWriteRepository.RemoveAsync(contentCategory);
        }

        public async Task<List<ContentCategoryDto>> GetAllContentCategories()
        {
            var contentCategories = _contentCategoryReadRepository.GetAll().ToList();
            var contentCategoryDto = _mapper.Map<List<ContentCategoryDto>>(contentCategories);
            return contentCategoryDto;
        }

        public async Task<ContentCategoryDto> GetContentCategoryByCode(string code)
        {
            var contentCategory = _contentCategoryReadRepository.GetWhere(x => x.Code == code).FirstOrDefault();
            var contentCategoryDto = _mapper.Map<ContentCategoryDto>(contentCategory);
            return contentCategoryDto;
        }

        public async Task Save(ContentCategoryDto brandDto)
        {
            ContentCategory contentCategory = new();
            contentCategory.Code = Guid.NewGuid().ToString();
            contentCategory.Name = brandDto.Name;
            await _contentCategoryWriteRepository.AddAsync(contentCategory);

        }

        public async Task Update(ContentCategoryDto contentCategoryDto)
        {
            var brand = _mapper.Map<ContentCategory>(contentCategoryDto);
            await _contentCategoryWriteRepository.UpdateAsync(brand, contentCategoryDto.Id);
        }
    }
}
