using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Unihanlin.AbpUploadService;

[DependsOn(
    typeof(AbpUploadServiceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AbpUploadServiceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AbpUploadServiceApplicationContractsModule).Assembly,
            AbpUploadServiceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpUploadServiceHttpApiClientModule>();
        });
    }
}
