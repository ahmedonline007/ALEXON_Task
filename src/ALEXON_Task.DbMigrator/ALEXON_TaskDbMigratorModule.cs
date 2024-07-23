using ALEXON_Task.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ALEXON_Task.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ALEXON_TaskEntityFrameworkCoreModule),
    typeof(ALEXON_TaskApplicationContractsModule)
    )]
public class ALEXON_TaskDbMigratorModule : AbpModule
{
}
