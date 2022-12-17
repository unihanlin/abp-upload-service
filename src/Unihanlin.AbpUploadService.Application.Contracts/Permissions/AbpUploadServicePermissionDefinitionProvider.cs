using Unihanlin.AbpUploadService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Unihanlin.AbpUploadService.Permissions;

public class AbpUploadServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpUploadServicePermissions.GroupName, L("Permission:AbpUploadService"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpUploadServiceResource>(name);
    }
}
