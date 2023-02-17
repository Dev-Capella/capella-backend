using Application.DataTransferObject;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IOptionsService
    {
       Task Save(OptionsDto optionsDto, Classification classification);
    }
}
