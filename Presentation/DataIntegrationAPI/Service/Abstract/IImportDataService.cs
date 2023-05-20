

using DataIntegrationAPI.Enums;

namespace DataIntegrationAPI.Service.Abstract;

public interface IImportDataService
{
    Task<(bool, string)> ImportData(Type itemType, List<Dictionary<string, object>> data, ImportProcessType importProcessType);
}