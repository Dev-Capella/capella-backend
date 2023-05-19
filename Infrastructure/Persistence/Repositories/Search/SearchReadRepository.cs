using System.Text;
using Application.Repositories.Search;
using Domain.Entities.Common;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories.Search;

public class SearchReadRepository : ISearchReadRepository
{
    private readonly CapellaDbContext _capellaDbContext;

    public SearchReadRepository(CapellaDbContext capellaDbContext)
    {
        _capellaDbContext = capellaDbContext;
    }
    
    public int SearchSingleResult(Type tableClass, Dictionary<string, object> parameters, SearchOperator searchOperator)
    {
        var query = CreateQuery(tableClass, parameters, searchOperator);
        try
        {
            return _capellaDbContext.Database.ExecuteSqlRaw(query);
        }
        catch (ApplicationException e)
        {
            throw e;
        }
    }
    
    
    private string CreateQuery(Type itemClass, IDictionary<string, object> parameters, SearchOperator searchOperator)
    {
        var queryBuilder = new StringBuilder();
        queryBuilder.Append($"SELECT m FROM {itemClass.Name} m");

        var nullFields = new Dictionary<string, object>();
        if (parameters != null && parameters.Count > 0)
        {
            foreach (var parameter in parameters)
            {
                if (parameter.Value == null)
                {
                    nullFields[parameter.Key] = parameter.Value;
                }
            }

            foreach (var nullField in nullFields)
            {
                parameters.Remove(nullField.Key);
            }
        }

        if (parameters != null && parameters.Count > 0)
        {
            queryBuilder.Append(" WHERE ");
            var isFirst = true;
            foreach (var parameter in parameters)
            {
                if (!isFirst)
                {
                    queryBuilder.Append($" {searchOperator} ");
                }

                queryBuilder.Append($"{parameter.Key} = @{parameter.Value}");
                isFirst = false;
            }
        }

        if (nullFields.Count > 0)
        {
            if (parameters != null && parameters.Count > 0)
            {
                queryBuilder.Append($" {searchOperator} ");
            }

            foreach (var nullField in nullFields)
            {
                queryBuilder.Append($"{nullField.Key} is null");
            }
        }

        return queryBuilder.ToString();
    }
}