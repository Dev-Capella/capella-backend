﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product: CodeBaseEntity
    {
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<ClassificationAttributeValue> ClassificationAttributeValues { get; set; }
        public ICollection<Media> Medias { get; set; }
        public ICollection<Gallery>? Galleries { get; set; }
        public ICollection<Variant> Variants { get; set; }
        public ICollection<VariantItem> VariantItems { get; set; }
        public Brand Brand { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<Tag> Tags { get; set; }

    }
}
