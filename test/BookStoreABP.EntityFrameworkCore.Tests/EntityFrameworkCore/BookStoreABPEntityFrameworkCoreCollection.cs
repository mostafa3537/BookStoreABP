using Xunit;

namespace BookStoreABP.EntityFrameworkCore;

[CollectionDefinition(BookStoreABPTestConsts.CollectionDefinitionName)]
public class BookStoreABPEntityFrameworkCoreCollection : ICollectionFixture<BookStoreABPEntityFrameworkCoreFixture>
{

}
