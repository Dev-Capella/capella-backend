using System.Data;
using System.Data.Common;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Emit;
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
       // var query = CreateQuery(tableClass, parameters, searchOperator);
        try
        {
            List<dynamic> results = DynamicListFromSql(_capellaDbContext, "select * from capella.\"MediaFormats\"", new Dictionary<string, object> {}).ToList();
            return 1;
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


    private static IEnumerable<dynamic> DynamicListFromSql(CapellaDbContext db, string Sql, Dictionary<string, object> Params)
    {
        using (var cmd = db.Database.GetDbConnection().CreateCommand())
        {
            cmd.CommandText = Sql;
            if (cmd.Connection.State != ConnectionState.Open) { cmd.Connection.Open(); }

            foreach (KeyValuePair<string, object> p in Params)
            {
                DbParameter dbParameter = cmd.CreateParameter();
                dbParameter.ParameterName = p.Key;
                dbParameter.Value = p.Value;
                cmd.Parameters.Add(dbParameter);
            }

            using (var dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    var row = new ExpandoObject() as IDictionary<string, object>;
                    for (var fieldCount = 0; fieldCount < dataReader.FieldCount; fieldCount++)
                    {
                        row.Add(dataReader.GetName(fieldCount), dataReader[fieldCount]);
                    }
                    yield return row;
                }
            }
        }
    }
}