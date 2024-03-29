﻿using Application.DataTransferObject.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class RoleDto: BaseDto
    {
        public RoleDto()
        {
            Permissions = new HashSet<PermissionDto>();
        }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public ICollection<PermissionDto>? Permissions { get; set; }

    }
}
