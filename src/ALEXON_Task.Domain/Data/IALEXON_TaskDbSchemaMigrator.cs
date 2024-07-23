using System.Threading.Tasks;

namespace ALEXON_Task.Data;

public interface IALEXON_TaskDbSchemaMigrator
{
    Task MigrateAsync();
}
