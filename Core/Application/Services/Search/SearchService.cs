using Application.Constant;
using Domain.Entities.Common;
using Domain.Enums;

namespace Application.Services.Search;

public interface ISearchService
{
    int SearchSingleResult(Type tableClass, Dictionary<string, object> parameters, SearchOperator searchOperator);
}