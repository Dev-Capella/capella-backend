using Domain.Enums;

namespace Application.Services.ImportData;

public interface IImportDataService
{
    Task<(bool, string)> ImportData(Type itemType, List<Dictionary<string, object>> data, ImportProcessType importProcessType);
}