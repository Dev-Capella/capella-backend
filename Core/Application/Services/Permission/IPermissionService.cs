﻿using Application.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Permission
{
    public interface IPermissionService
    {
        Task<List<PermissionDto>> GetAllPermission();
    }
}
