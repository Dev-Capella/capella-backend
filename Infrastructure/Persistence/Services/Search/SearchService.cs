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
using Application.Constant;
using Application.Repositories.Search;

namespace Persistence.Services.Search;

public class SearchService: ISearchService
{
    private readonly ISearchReadRepository _searchReadRepository;

    public SearchService(ISearchReadRepository searchReadRepository)
    {
        _searchReadRepository = searchReadRepository;
    }

    public int SearchSingleResult(Type tableClass, Dictionary<string, object> parameters, SearchOperator searchOperator)
    {
        return _searchReadRepository.SearchSingleResult(tableClass, parameters, searchOperator);
    }
    
    
}