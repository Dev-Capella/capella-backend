using System.Linq.Expressions;
using System.Text;
using Application.Services.Search;
using Domain.Entities.Common;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Primitives;
using Persistence.Contexts;
using System.Data.SqlClient;

namespace Persistence.Services.Search;

public class SearchService: ISearchService
{
    private CapellaDbContext _capellaDbContext;

    public SearchService(CapellaDbContext capellaDbContext)
    {
        _capellaDbContext = capellaDbContext;
    }
    
    public T SearchSingleResult<T>(Type tableClass, Dictionary<string, object> parameters, SearchOperator searchOperator) where T : BaseEntity
    {
        try
        {
            var entity = _capellaDbContext.Set<T>()
            return entity;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }
}