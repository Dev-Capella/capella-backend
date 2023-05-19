using Domain.Enums;

namespace Application.Repositories.Search;

public interface ISearchReadRepository
{
    int SearchSingleResult(Type tableClass, Dictionary<string, object> parameters, SearchOperator searchOperator);

}