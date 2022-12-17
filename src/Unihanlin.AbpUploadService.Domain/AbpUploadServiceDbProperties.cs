namespace Unihanlin.AbpUploadService;

public static class AbpUploadServiceDbProperties
{
    public static string DbTablePrefix { get; set; } = "AbpUploadService";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "AbpUploadService";
}
