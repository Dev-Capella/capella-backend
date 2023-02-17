using Application.Repositories;
using Application.Services;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.BackgroundJob.Jobs;

public class ClearMediaCronJob
{
    private readonly IMediaReadRepository _mediaReadRepository;
    private readonly IMediaWriteRepository _mediaWriteRepository;
    public ClearMediaCronJob(
        IMediaReadRepository mediaReadRepository,
        IMediaWriteRepository mediaWriteRepository)
    {
        _mediaReadRepository = mediaReadRepository;
        _mediaWriteRepository = mediaWriteRepository;
    }

    public async Task Run()
    {
        var medias = _mediaReadRepository.GetWhere((x=> x.Deleted==true)).ToList();
        try
        {
            foreach (var item in medias)
            {
                var mediaFilePath = item.RootPath + item.AbsolutePath;
                File.Delete((mediaFilePath));
                var mediaFirstLevelFolder = Directory.GetParent(mediaFilePath).FullName;
                var mediaSecondLevelFolder = Directory.GetParent(mediaFirstLevelFolder).FullName;
                if (Directory.GetFiles(mediaFirstLevelFolder).Length==0)
                {
                    Directory.Delete(mediaFirstLevelFolder);
                }
                if (Directory.GetFiles(mediaSecondLevelFolder).Length==0 && Directory.GetDirectories(mediaSecondLevelFolder).Length==0)
                {
                    Directory.Delete(mediaSecondLevelFolder);
                }
                await _mediaWriteRepository.RemoveAsync(item);
            }
        }
        catch (Exception exception)
        {
            throw exception;
        }
    }


}