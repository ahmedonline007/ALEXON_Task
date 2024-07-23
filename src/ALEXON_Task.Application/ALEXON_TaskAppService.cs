using System;
using System.Collections.Generic;
using System.Text;
using ALEXON_Task.Localization;
using Volo.Abp.Application.Services;

namespace ALEXON_Task;

/* Inherit your application services from this class.
 */
public abstract class ALEXON_TaskAppService : ApplicationService
{
    protected ALEXON_TaskAppService()
    {
        LocalizationResource = typeof(ALEXON_TaskResource);
    }
}
