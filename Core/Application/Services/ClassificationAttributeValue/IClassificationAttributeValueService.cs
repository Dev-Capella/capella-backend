﻿using Application.DataTransferObject;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IClassificationAttributeValueService
    {
        Task<ClassificationAttributeValue> Save(ClassificationAttributeValueDto classificationAttributeValueDto);
        Task<ClassificationAttributeValue> Update(ClassificationAttributeValueDto classificationAttributeValueDto);
        Task Delete(string code);
    }
}
