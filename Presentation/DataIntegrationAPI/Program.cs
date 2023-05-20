using DataIntegrationAPI.Repository.Abstract;
using DataIntegrationAPI.Repository.Concrete;
using DataIntegrationAPI.Schedules;
using DataIntegrationAPI.Service.Abstract;
using DataIntegrationAPI.Service.Concrete;
using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IQueryService, QueryService>();
builder.Services.AddScoped<IImportDataService, ImportDataService>();
builder.Services.AddScoped<IFileImportService, FileImportService>();
builder.Services.AddDbContext<CapellaDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));

builder.Services.AddHangfire(configuration => configuration
    .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
    .UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UsePostgreSqlStorage("User ID=postgres;Password=1234;Host=localhost;Port=5432;Database=hangfiredb"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseHangfireDashboard();
app.UseHangfireServer(new BackgroundJobServerOptions
{
    SchedulePollingInterval = TimeSpan.FromSeconds(30),
    WorkerCount = Environment.ProcessorCount * 5
});

RecurringJobs.ImportCsvFileListenerOperation();
app.Run();
