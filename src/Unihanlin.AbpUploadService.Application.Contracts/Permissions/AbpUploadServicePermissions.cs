using Volo.Abp.Reflection;

namespace Unihanlin.AbpUploadService.Permissions;

public class AbpUploadServicePermissions
{
    public const string GroupName = "AbpUploadService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AbpUploadServicePermissions));
    }
}
