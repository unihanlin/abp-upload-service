using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Unihanlin.AbpUploadService.Seed;

public class AbpUploadServiceAuthServerDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly AbpUploadServiceSampleIdentityDataSeeder _abpUploadServiceSampleIdentityDataSeeder;
    private readonly AbpUploadServiceAuthServerDataSeeder _abpUploadServiceAuthServerDataSeeder;
    private readonly ICurrentTenant _currentTenant;

    public AbpUploadServiceAuthServerDataSeedContributor(
        AbpUploadServiceAuthServerDataSeeder abpUploadServiceAuthServerDataSeeder,
        AbpUploadServiceSampleIdentityDataSeeder abpUploadServiceSampleIdentityDataSeeder,
        ICurrentTenant currentTenant)
    {
        _abpUploadServiceAuthServerDataSeeder = abpUploadServiceAuthServerDataSeeder;
        _abpUploadServiceSampleIdentityDataSeeder = abpUploadServiceSampleIdentityDataSeeder;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            await _abpUploadServiceSampleIdentityDataSeeder.SeedAsync(context);
            await _abpUploadServiceAuthServerDataSeeder.SeedAsync(context);
        }
    }
}
