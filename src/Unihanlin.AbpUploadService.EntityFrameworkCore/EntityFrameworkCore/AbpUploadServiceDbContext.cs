using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Unihanlin.AbpUploadService.EntityFrameworkCore;

[ConnectionStringName(AbpUploadServiceDbProperties.ConnectionStringName)]
public class AbpUploadServiceDbContext : AbpDbContext<AbpUploadServiceDbContext>, IAbpUploadServiceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AbpUploadServiceDbContext(DbContextOptions<AbpUploadServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAbpUploadService();
    }
}
