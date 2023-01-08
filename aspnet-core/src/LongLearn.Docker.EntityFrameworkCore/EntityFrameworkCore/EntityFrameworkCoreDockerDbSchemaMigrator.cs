using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LongLearn.Docker.Data;
using Volo.Abp.DependencyInjection;

namespace LongLearn.Docker.EntityFrameworkCore;

public class EntityFrameworkCoreDockerDbSchemaMigrator
    : IDockerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDockerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DockerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DockerDbContext>()
            .Database
            .MigrateAsync();
    }
}
