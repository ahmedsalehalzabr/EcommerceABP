using EcommerceApp.Samples;
using Xunit;

namespace EcommerceApp.EntityFrameworkCore.Domains;

[Collection(EcommerceAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EcommerceAppEntityFrameworkCoreTestModule>
{

}
