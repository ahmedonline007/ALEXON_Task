using Volo.Abp.Modularity;

namespace ALEXON_Task;

[DependsOn(
    typeof(ALEXON_TaskApplicationModule),
    typeof(ALEXON_TaskDomainTestModule)
)]
public class ALEXON_TaskApplicationTestModule : AbpModule
{

}
