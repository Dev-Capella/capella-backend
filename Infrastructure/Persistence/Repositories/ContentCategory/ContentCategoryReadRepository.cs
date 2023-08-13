using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ContentCategoryReadRepository : ReadRepository<ContentCategory> , IContentCategoryReadRepository
    {
        public ContentCategoryReadRepository(CapellaDbContext context) : base(context)
        {
                
        }
    }
}
