using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ALEXON_Task;

[Dependency(ReplaceServices = true)]
public class ALEXON_TaskBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ALEXON_Task";
}
