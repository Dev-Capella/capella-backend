﻿using Application.Repositories.ProductAbstract;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(CapellaDbContext context) : base(context)
        {

        }
    }
}
