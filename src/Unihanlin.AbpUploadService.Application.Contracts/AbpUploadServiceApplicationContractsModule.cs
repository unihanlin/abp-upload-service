using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpUploadService;

[DependsOn(
    typeof(AbpUploadServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule)
    )]
public class AbpUploadServiceApplicationContractsModule : AbpModule
{

}
