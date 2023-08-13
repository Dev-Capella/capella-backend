using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class DataImportDto
    {
        public string Model { get; set; }

        public string Action { get; set; }

        public JToken Json { get; set; }
    }
}
