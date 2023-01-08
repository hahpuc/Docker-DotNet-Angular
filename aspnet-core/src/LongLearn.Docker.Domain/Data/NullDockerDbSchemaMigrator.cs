using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LongLearn.Docker.Data;

/* This is used if database provider does't define
 * IDockerDbSchemaMigrator implementation.
 */
public class NullDockerDbSchemaMigrator : IDockerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
