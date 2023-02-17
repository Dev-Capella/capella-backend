using Application.DataTransferObject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class VariantItemDto: BaseDto
    {

        public string? Code { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public string? Barcode { get; set; }

        public bool Active = true;
        public ICollection<ClassificationDto>? Classifications { get; set; }
        public ICollection<ClassificationAttributeValueDto>? ClassificationAttributeValues { get; set; }
        public ICollection<FileDto>? Files { get; set; }
        public ICollection<VariantValueDto>? VariantValues { get; set; }
        public ICollection<GalleryDto>? Galleries { get; set; }

    }
}
