using Volo.Abp.Modularity;

namespace ALEXON_Task;

public abstract class ALEXON_TaskApplicationTestBase<TStartupModule> : ALEXON_TaskTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
