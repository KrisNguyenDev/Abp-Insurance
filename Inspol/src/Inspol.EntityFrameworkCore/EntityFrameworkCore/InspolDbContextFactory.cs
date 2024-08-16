using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Inspol.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class InspolDbContextFactory : IDesignTimeDbContextFactory<InspolDbContext>
{
    public InspolDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        InspolEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<InspolDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new InspolDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Inspol.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
