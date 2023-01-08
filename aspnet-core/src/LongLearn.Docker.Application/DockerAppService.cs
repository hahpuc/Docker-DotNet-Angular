using System;
using System.Collections.Generic;
using System.Text;
using LongLearn.Docker.Localization;
using Volo.Abp.Application.Services;

namespace LongLearn.Docker;

/* Inherit your application services from this class.
 */
public abstract class DockerAppService : ApplicationService
{
    protected DockerAppService()
    {
        LocalizationResource = typeof(DockerResource);
    }
}
