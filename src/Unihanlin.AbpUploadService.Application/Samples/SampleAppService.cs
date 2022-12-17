using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Unihanlin.AbpUploadService.Samples;

public class SampleAppService : AbpUploadServiceAppService, ISampleAppService
{
    public Task<SampleDto> GetAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    [Authorize]
    public Task<SampleDto> GetAuthorizedAsync()
    {
        return Task.FromResult(
            new SampleDto
            {
                Value = 42
            }
        );
    }

    public Task<bool> UploadAsync(UploadDto input)
    {
        return Task.FromResult(true);
    }
}
