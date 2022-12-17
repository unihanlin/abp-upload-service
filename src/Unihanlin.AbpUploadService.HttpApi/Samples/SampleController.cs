using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Unihanlin.AbpUploadService.Samples;

[Area(AbpUploadServiceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = AbpUploadServiceRemoteServiceConsts.RemoteServiceName)]
[Route("api/AbpUploadService/sample")]
public class SampleController : AbpUploadServiceController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
