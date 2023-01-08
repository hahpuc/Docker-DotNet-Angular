using LongLearn.Docker.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LongLearn.Docker;

[DependsOn(
    typeof(DockerEntityFrameworkCoreTestModule)
    )]
public class DockerDomainTestModule : AbpModule
{

}
