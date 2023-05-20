using DataIntegrationAPI.Enums;
using DataIntegrationAPI.Service.Abstract;
using System.Text;

namespace DataIntegrationAPI.Service.Concrete
{
    public class QueryService : IQueryService
    {
        public string SelectQuery(string tableName, Dictionary<string, object> parameters, SearchOperator searchOperator)
        {
            var queryBuilder = new StringBuilder();
            queryBuilder.Append($"SELECT * FROM capella.\"{tableName}s\"");

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

                    queryBuilder.Append($"\"{parameter.Key}\" = '{parameter.Value}'");
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

        public string InsertQuery(string tableName, Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
