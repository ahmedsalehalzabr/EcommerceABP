using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EcommerceApp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class EcommerceAppDbContextFactory : IDesignTimeDbContextFactory<EcommerceAppDbContext>
{
    public EcommerceAppDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        EcommerceAppEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<EcommerceAppDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new EcommerceAppDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../EcommerceApp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
