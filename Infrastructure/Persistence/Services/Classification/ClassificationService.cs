using Application.DataTransferObject;
using Application.Repositories;
using Application.Repositories.ProductAbstract;
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
    public class ClassificationService : IClassificationService
    {
        private readonly IClassificationReadRepository _classificationReadRepository;
        private readonly IClassificationWriteRepository _classificationWriteRepository;
        private readonly IOptionsService _optionsService;
        private readonly IMapper _mapper;

        public ClassificationService(IClassificationReadRepository classificationReadRepository,
            IClassificationWriteRepository classificationWriteRepository,
            IMapper mapper,
            IOptionsService optionsService)
        {
            _classificationReadRepository = classificationReadRepository;
            _classificationWriteRepository = classificationWriteRepository;   
            _mapper = mapper;
            _optionsService = optionsService;
        }
        public async Task Save(ClassificationDto classificationDto)
        {
            
            Classification classification = new();
            classification.Name = classificationDto.Name;
            classification.Code = Guid.NewGuid().ToString();
            classification.DataType = (Domain.Enums.DataType)classificationDto.DataType;
            var options = new HashSet<Options>();
            foreach(var item in classificationDto.Options)
            {
                item.Code = Guid.NewGuid().ToString();
                var option = _mapper.Map<Options>(item);
                options.Add(option);

            }
            classification.Options = options;
            await _classificationWriteRepository.AddAsync(classification);
            
        }

        public async Task<List<ClassificationDto>> GetAllClassifications()
        {
            var classifications = await _classificationReadRepository.GetAllWithIncludeStringParam(true,
                "Options").ToListAsync();
            var classificationDto = _mapper.Map<List<ClassificationDto>>(classifications);
            return classificationDto;
        }

        public async Task<ClassificationDto> GetClassificationByCode(string code)
        {
            var classification = await _classificationReadRepository.GetWhereWithInclude(x => x.Code == code, true, x => x.Options).FirstOrDefaultAsync();
            var classificationDto = _mapper.Map<ClassificationDto>(classification);
            return classificationDto;
        }

        public async Task Update(ClassificationDto classificationDto)
        {
            var classification = _classificationReadRepository.GetWhere(x => x.Code == classificationDto.Code).Include(x=> x.Options).FirstOrDefault();
            classification.Name = classificationDto.Name;
            classification.Code = classificationDto.Code;
            classification.DataType = (Domain.Enums.DataType)classificationDto.DataType;
            var options = new HashSet<Options>();
            foreach (var item in classificationDto.Options)
            {
                await _optionsService.Save(item, classification);

            }
            classification.Options = options;
            await _classificationWriteRepository.UpdateAsync(classification, classification.Id);
        }

        public async Task Delete(string code)
        {
            var classification = _classificationReadRepository.GetWhere(x => x.Code == code).FirstOrDefault();
            await _classificationWriteRepository.RemoveAsync(classification);
        }
    }
}
