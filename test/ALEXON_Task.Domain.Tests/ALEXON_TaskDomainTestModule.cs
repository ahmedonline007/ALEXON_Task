using Volo.Abp.Modularity;

namespace ALEXON_Task;

[DependsOn(
    typeof(ALEXON_TaskDomainModule),
    typeof(ALEXON_TaskTestBaseModule)
)]
public class ALEXON_TaskDomainTestModule : AbpModule
{

}
