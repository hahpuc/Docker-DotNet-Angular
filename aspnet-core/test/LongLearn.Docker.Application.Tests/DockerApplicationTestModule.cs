using Volo.Abp.Modularity;

namespace LongLearn.Docker;

[DependsOn(
    typeof(DockerApplicationModule),
    typeof(DockerDomainTestModule)
    )]
public class DockerApplicationTestModule : AbpModule
{

}
