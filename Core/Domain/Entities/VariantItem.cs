﻿using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class VariantItem: CodeBaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public string Barcode { get; set; }
        public ICollection<ClassificationAttributeValue> ClassificationAttributeValues { get; set; }
        public ICollection<Gallery> Galleries { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<VariantValue> VariantValues { get; set; }
    }
}
