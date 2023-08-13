using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class MediaFormDto
    {
        public string Code { get; set; }
        public List<IFormFile> Medias { get; set; }
    }
}
