using Volo.Abp.Caching;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpUploadService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpCachingModule),
    typeof(AbpUploadServiceDomainSharedModule)
)]
public class AbpUploadServiceDomainModule : AbpModule
{

}
