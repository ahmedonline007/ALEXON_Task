using ALEXON_Task.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ALEXON_Task.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ALEXON_TaskController : AbpControllerBase
{
    protected ALEXON_TaskController()
    {
        LocalizationResource = typeof(ALEXON_TaskResource);
    }
}
