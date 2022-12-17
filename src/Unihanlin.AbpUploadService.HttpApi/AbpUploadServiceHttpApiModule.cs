using Localization.Resources.AbpUi;
using Unihanlin.AbpUploadService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Unihanlin.AbpUploadService;

[DependsOn(
    typeof(AbpUploadServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AbpUploadServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpUploadServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.FormBodyBindingIgnoredTypes.Add(typeof(UploadDto));
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpUploadServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
