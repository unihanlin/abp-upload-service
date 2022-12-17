using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Unihanlin.AbpUploadService.EntityFrameworkCore;

public class AbpUploadServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpUploadServiceHttpApiHostMigrationsDbContext>
{
    public AbpUploadServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpUploadServiceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AbpUploadService"));

        return new AbpUploadServiceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
