using System.Threading.Tasks;

namespace LongLearn.Docker.Data;

public interface IDockerDbSchemaMigrator
{
    Task MigrateAsync();
}
