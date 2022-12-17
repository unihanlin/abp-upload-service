using Unihanlin.AbpUploadService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Unihanlin.AbpUploadService;

public abstract class AbpUploadServiceController : AbpControllerBase
{
    protected AbpUploadServiceController()
    {
        LocalizationResource = typeof(AbpUploadServiceResource);
    }
}
