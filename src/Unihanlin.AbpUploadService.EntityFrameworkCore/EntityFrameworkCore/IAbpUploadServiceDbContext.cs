using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Unihanlin.AbpUploadService.EntityFrameworkCore;

[ConnectionStringName(AbpUploadServiceDbProperties.ConnectionStringName)]
public interface IAbpUploadServiceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
