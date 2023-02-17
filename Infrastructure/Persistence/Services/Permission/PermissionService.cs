using Application.DataTransferObject;
using Application.Repositories;
using Application.Services.Permission;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.Permission
{
    public class PermissionService : IPermissionService
    {
        private readonly IMapper _mapper; 
        private readonly IPermissionReadRepository _permissionReadRepository;
        public PermissionService(IMapper mapper, IPermissionReadRepository permissionReadRepository)
        {
            _mapper = mapper;
            _permissionReadRepository = permissionReadRepository;
        }
    
        public async Task<List<PermissionDto>> GetAllPermission()
        {
            var permission = await _permissionReadRepository.GetAll().ToListAsync();
            var permissionDto = _mapper.Map<List<PermissionDto>>(permission);
            return permissionDto;
        }
    }
}
