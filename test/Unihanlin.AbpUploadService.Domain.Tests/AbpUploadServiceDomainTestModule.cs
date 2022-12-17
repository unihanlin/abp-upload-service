using Unihanlin.AbpUploadService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpUploadService;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AbpUploadServiceEntityFrameworkCoreTestModule)
    )]
public class AbpUploadServiceDomainTestModule : AbpModule
{

}
