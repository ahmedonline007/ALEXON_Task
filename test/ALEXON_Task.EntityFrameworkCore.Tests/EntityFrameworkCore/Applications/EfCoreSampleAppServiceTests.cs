using ALEXON_Task.Samples;
using Xunit;

namespace ALEXON_Task.EntityFrameworkCore.Applications;

[Collection(ALEXON_TaskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ALEXON_TaskEntityFrameworkCoreTestModule>
{

}
