using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ALEXON_Task.Data;

/* This is used if database provider does't define
 * IALEXON_TaskDbSchemaMigrator implementation.
 */
public class NullALEXON_TaskDbSchemaMigrator : IALEXON_TaskDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
