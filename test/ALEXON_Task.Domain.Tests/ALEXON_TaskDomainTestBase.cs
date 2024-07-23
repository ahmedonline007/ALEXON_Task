using Volo.Abp.Modularity;

namespace ALEXON_Task;

/* Inherit from this class for your domain layer tests. */
public abstract class ALEXON_TaskDomainTestBase<TStartupModule> : ALEXON_TaskTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
