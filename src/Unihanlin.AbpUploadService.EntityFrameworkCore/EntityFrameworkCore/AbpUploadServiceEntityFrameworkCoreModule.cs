using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpUploadService.EntityFrameworkCore;

[DependsOn(
    typeof(AbpUploadServiceDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class AbpUploadServiceEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AbpUploadServiceDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
