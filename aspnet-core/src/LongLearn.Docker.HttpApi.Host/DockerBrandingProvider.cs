using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LongLearn.Docker;

[Dependency(ReplaceServices = true)]
public class DockerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Docker";
}
