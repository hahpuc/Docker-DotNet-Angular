using LongLearn.Docker.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LongLearn.Docker.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DockerEntityFrameworkCoreModule),
    typeof(DockerApplicationContractsModule)
    )]
public class DockerDbMigratorModule : AbpModule
{

}
