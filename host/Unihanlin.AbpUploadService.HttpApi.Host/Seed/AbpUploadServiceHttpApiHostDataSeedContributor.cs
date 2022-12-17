using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Unihanlin.AbpUploadService.Seed;

public class AbpUploadServiceHttpApiHostDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly AbpUploadServiceSampleDataSeeder _abpUploadServiceSampleDataSeeder;
    private readonly ICurrentTenant _currentTenant;

    public AbpUploadServiceHttpApiHostDataSeedContributor(
        AbpUploadServiceSampleDataSeeder abpUploadServiceSampleDataSeeder,
        ICurrentTenant currentTenant)
    {
        _abpUploadServiceSampleDataSeeder = abpUploadServiceSampleDataSeeder;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            await _abpUploadServiceSampleDataSeeder.SeedAsync(context);
        }
    }
}
