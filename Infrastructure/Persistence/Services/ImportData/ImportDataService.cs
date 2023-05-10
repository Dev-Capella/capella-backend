using Application.Services.ImportData;
using Domain.Enums;

namespace Persistence.Services.ImportData;

public class ImportDataService: IImportDataService
{
    public Task<(bool, string)> ImportData(Type type, List<Dictionary<string, object>> data, ImportProcessType importProcessType)
    {
        throw new NotImplementedException();
    }
}