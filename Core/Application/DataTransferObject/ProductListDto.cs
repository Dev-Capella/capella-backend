using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObject
{
    public class ProductListDto
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public decimal? Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        public ICollection<GalleryDto>? Galleries { get; set; }
        public ICollection<CategoryDto>? Categories { get; set; }
        public ICollection<VariantDto>? Variants { get; set; }
        public BrandDto? Brand { get; set; }
        public ICollection<TagDto>? Tags { get; set; }
    }
}
