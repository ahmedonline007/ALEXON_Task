using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ALEXON_Task.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ALEXON_TaskDbContextFactory : IDesignTimeDbContextFactory<ALEXON_TaskDbContext>
{
    public ALEXON_TaskDbContext CreateDbContext(string[] args)
    {
        ALEXON_TaskEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ALEXON_TaskDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ALEXON_TaskDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ALEXON_Task.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
