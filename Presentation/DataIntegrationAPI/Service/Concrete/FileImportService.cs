using CsvHelper;
using DataIntegrationAPI.Enums;
using DataIntegrationAPI.Helpers;
using DataIntegrationAPI.Service.Abstract;
using System.Globalization;
using System.Text;

namespace DataIntegrationAPI.Service.Concrete;

public class FileImportService: IFileImportService
{
    
    private readonly IImportDataService _importDataService;

    public FileImportService(IImportDataService importDataService)
    {
        _importDataService = importDataService;
    }
    public async Task<(bool, string)> ImportFile(FileInfo file, bool isMoveFile)
    {
        try
        {
            var processTypeIndex = 0;
            var itemTypeIndex = 1;
            var itemAndProcessType = file.Name.Split("_");
            var processType = itemAndProcessType[processTypeIndex];
            var typeName = itemAndProcessType[itemTypeIndex];

            ImportProcessType importProcessType;
            if(processType.Equals(ImportProcessType.SAVE.ToString(),StringComparison.OrdinalIgnoreCase))
            {
                importProcessType = ImportProcessType.SAVE;
            }else if (processType.Equals(ImportProcessType.REMOVE.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                importProcessType = ImportProcessType.REMOVE;
            }else if (processType.Equals(ImportProcessType.FILE.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                importProcessType = ImportProcessType.FILE;
            }
            else
            {
                throw new Exception("İçeri alma tipini düzgün belirtiniz.");
            }

            var tclass = CapellaClassUtils.GetClassForNamespace("MediaFormat", NamespaceConstant.ENTITY_PREFIX, NamespaceConstant.DOMAIN);
            using (var reader = new StreamReader(file.FullName))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                var headerRecord = csv.HeaderRecord;

                List<Dictionary<string, object>> allRows = new List<Dictionary<string, object>>();
                while (csv.Read())
                {
                    var record = csv.GetRecord<dynamic>();
                    var row = new Dictionary<string, object>();
                    foreach (var header in headerRecord)
                    {
                        row.Add(header, ((IDictionary<string, object>)record)[header]);
                    }
                    allRows.Add(row);
                }

                await _importDataService.ImportData(tclass, allRows, importProcessType);
            }

        }
        catch  (Exception ex)
        {
            throw ex;
        }
        throw new NotImplementedException();
    }
}