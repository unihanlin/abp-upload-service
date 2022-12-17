using Unihanlin.AbpUploadService.Localization;
using Volo.Abp.Application.Services;

namespace Unihanlin.AbpUploadService;

public abstract class AbpUploadServiceAppService : ApplicationService
{
    protected AbpUploadServiceAppService()
    {
        LocalizationResource = typeof(AbpUploadServiceResource);
        ObjectMapperContext = typeof(AbpUploadServiceApplicationModule);
    }
}
