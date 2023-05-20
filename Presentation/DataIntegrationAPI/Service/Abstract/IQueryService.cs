using DataIntegrationAPI.Enums;

namespace DataIntegrationAPI.Service.Abstract;

public interface IQueryService
{
    string SelectQuery(string tableName, Dictionary<string, object> parameters, SearchOperator searchOperator);

    string InsertQuery(string tableName, Dictionary<string, object> parameters);
}