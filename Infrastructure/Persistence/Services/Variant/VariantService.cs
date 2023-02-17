using Application.DataTransferObject;
using Application.Repositories;
using Application.Services;
using Application.Services.Variant;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class VariantService : IVariantService
    {
        private readonly IVariantWriteRepository _variantWriteRepository;
        private readonly IVariantReadRepository _variantReadRepository;
        private readonly IVariantValueService _variantValueService;
        private readonly IMapper _mapper;

        public VariantService(IVariantWriteRepository variantWriteRepository, IVariantReadRepository variantReadRepository, IVariantValueService variantValueService, IMapper mapper)
        {
            _variantReadRepository = variantReadRepository;
            _variantWriteRepository = variantWriteRepository;
            _variantValueService = variantValueService;
            _mapper = mapper;
        }

        public async Task Delete(string code)
        {
            var variant = _variantReadRepository.GetWhere(x => x.Code == code).FirstOrDefault();
            await _variantWriteRepository.RemoveAsync(variant);
        }

        public async Task<List<VariantDto>> GetAllVariants()
        {
            var variants = _variantReadRepository.GetAllWithInclude(true, x => x.VariantValues).ToList();
            var variantsDto = _mapper.Map<List<VariantDto>>(variants);
            return variantsDto;
        }

        public async Task<VariantDto> GetVariantByCode(string code)
        {
            var variant = _variantReadRepository.GetWhereWithInclude(x => x.Code == code, true, x => x.VariantValues).FirstOrDefault();
            var variantDto = _mapper.Map<VariantDto>(variant);
            return variantDto;
        }

        public async Task Save(VariantDto variantDto)
        {
            Variant variant = new();

            variant.Name = variantDto.Name;
            variant.Code = Guid.NewGuid().ToString();
          
            var variantValues = new HashSet<VariantValue>();
            foreach (var item in variantDto.VariantValues)
            {
                item.Code = Guid.NewGuid().ToString();
                var variantValue = _mapper.Map<VariantValue>(item);
                variantValues.Add(variantValue);

            }
            variant.VariantValues = variantValues;
            await _variantWriteRepository.AddAsync(variant);
        }

        public async Task Update(VariantDto variantDto)
        {
            var variant = _variantReadRepository.GetWhereWithInclude(x => x.Code == variantDto.Code, true, x => x.VariantValues).FirstOrDefault();
            variant.Name = variantDto.Name;
            variant.Code = variantDto.Code;

            var variantValues = new HashSet<VariantValue>();
            foreach (var item in variantDto.VariantValues)
            {
                item.Code = Guid.NewGuid().ToString();
                var variantValue = _mapper.Map<VariantValue>(item);
                variantValues.Add(variantValue);

            }
            variant.VariantValues = variantValues;
            await _variantWriteRepository.UpdateAsync(variant,variant.Id);
        }
    }
}
