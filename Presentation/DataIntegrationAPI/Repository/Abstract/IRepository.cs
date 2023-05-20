using DataIntegrationAPI.Enums;

namespace DataIntegrationAPI.Repository.Abstract
{
    public interface IRepository
    {
        int Insert(string query);
        List<dynamic> Get(string query);

    }
}
