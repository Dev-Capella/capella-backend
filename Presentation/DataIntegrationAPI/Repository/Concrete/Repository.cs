using DataIntegrationAPI.Enums;
using DataIntegrationAPI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Data;
using System.Dynamic;
using System.Text;

namespace DataIntegrationAPI.Repository.Concrete
{
    public class Repository:IRepository
    {
        private readonly CapellaDbContext _capellaDbContext;

        public Repository(CapellaDbContext capellaDbContext)
        {
            _capellaDbContext = capellaDbContext;
        }

        public List<dynamic> Get(string query)
        {
            try
            {
                var list=ListFromSql(_capellaDbContext,query);
                return list.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int Insert(string query)
        {
            try
            {
                var affectedRowCount = InsertFromSql(_capellaDbContext, query);
                return affectedRowCount;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private static IEnumerable<dynamic> ListFromSql(CapellaDbContext db, string Sql)
        {
            using (var cmd = db.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = Sql;
                if (cmd.Connection.State != ConnectionState.Open) { cmd.Connection.Open(); }

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

        private static int InsertFromSql(CapellaDbContext db, string Sql)
        {
            return 1;
        }
    }
}
