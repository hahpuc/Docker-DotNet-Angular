using LongLearn.Docker.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LongLearn.Docker.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DockerController : AbpControllerBase
{
    protected DockerController()
    {
        LocalizationResource = typeof(DockerResource);
    }
}
