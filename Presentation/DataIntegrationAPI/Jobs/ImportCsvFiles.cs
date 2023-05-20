

using DataIntegrationAPI.Service.Abstract;

namespace DataIntegrationAPI.Jobs;

public class ImportCsvFiles
{
    private readonly IConfiguration _configuration;
    private readonly IFileImportService _fileImportService;
    
    public ImportCsvFiles(IConfiguration configuration, IFileImportService fileImportService)
    {
        _configuration = configuration;
        _fileImportService = fileImportService;
    }
    public async Task Run()
    {
        var directoryName = Path.GetFullPath(_configuration["DataImport:CsvListenerFolderPath"]);

        var directoryInfo = new DirectoryInfo(directoryName);
        var fileInfo = directoryInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly).ToList();


        var processFiles = fileInfo.OrderBy(x => x.LastWriteTimeUtc).ToList();
        
        foreach (var processFile in processFiles)
        {
            await _fileImportService.ImportFile(processFile, true);
        }
    }
}