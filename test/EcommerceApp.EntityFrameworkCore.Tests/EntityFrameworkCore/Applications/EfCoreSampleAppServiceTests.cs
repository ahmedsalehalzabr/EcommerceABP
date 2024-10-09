using EcommerceApp.Samples;
using Xunit;

namespace EcommerceApp.EntityFrameworkCore.Applications;

[Collection(EcommerceAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EcommerceAppEntityFrameworkCoreTestModule>
{

}
