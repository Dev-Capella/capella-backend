using DataIntegrationAPI.Jobs;
using Hangfire;

namespace DataIntegrationAPI.Schedules;

public static class RecurringJobs
{
    public static void ImportCsvFileListenerOperation()
    {
        RecurringJob.AddOrUpdate<ImportCsvFiles>(nameof(ImportCsvFiles),
            job => job.Run(),Cron.MinuteInterval(1));
    }
    
}