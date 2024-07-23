using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ALEXON_Task.Data;
using Volo.Abp.DependencyInjection;

namespace ALEXON_Task.EntityFrameworkCore;

public class EntityFrameworkCoreALEXON_TaskDbSchemaMigrator
    : IALEXON_TaskDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreALEXON_TaskDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ALEXON_TaskDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ALEXON_TaskDbContext>()
            .Database
            .MigrateAsync();
    }
}
