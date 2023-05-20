namespace DataIntegrationAPI.Service.Abstract;

public interface IFileImportService
{ 
    Task<(bool, string)> ImportFile(FileInfo file, bool isMoveFile);
}