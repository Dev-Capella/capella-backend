using Hangfire;
using Infrastructure.BackgroundJob.Jobs;

namespace Infrastructure.BackgroundJob.Schedules;

public static class RecurringJobs
{
    public static void MediaDeleteOperation()
    {
        RecurringJob.AddOrUpdate<ClearMediaCronJob>(nameof(ClearMediaCronJob),
            job => job.Run(),"0 0 * * *", TimeZoneInfo.Local);
    }
    public static void ImportCsvFileListenerOperation()
    {
        RecurringJob.AddOrUpdate<ImportCsvFiles>(nameof(ImportCsvFiles),
            job => job.Run(),Cron.MinuteInterval(1));
    }
    
}