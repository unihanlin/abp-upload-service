using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpUploadService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpUploadServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AbpUploadServiceConsoleApiClientModule : AbpModule
{

}
