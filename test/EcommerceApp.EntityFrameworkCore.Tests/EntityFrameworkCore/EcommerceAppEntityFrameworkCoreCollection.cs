using Xunit;

namespace EcommerceApp.EntityFrameworkCore;

[CollectionDefinition(EcommerceAppTestConsts.CollectionDefinitionName)]
public class EcommerceAppEntityFrameworkCoreCollection : ICollectionFixture<EcommerceAppEntityFrameworkCoreFixture>
{

}
