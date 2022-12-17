using Volo.Abp.Modularity;

namespace Unihanlin.AbpUploadService;

[DependsOn(
    typeof(AbpUploadServiceApplicationModule),
    typeof(AbpUploadServiceDomainTestModule)
    )]
public class AbpUploadServiceApplicationTestModule : AbpModule
{

}
