namespace Application.Services.FileImport;

public interface IFileImportService
{ 
    Task<(bool, string)> ImportFile(FileInfo file, bool isMoveFile);
}