using ALEXON_Task.Samples;
using Xunit;

namespace ALEXON_Task.EntityFrameworkCore.Domains;

[Collection(ALEXON_TaskTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ALEXON_TaskEntityFrameworkCoreTestModule>
{

}
