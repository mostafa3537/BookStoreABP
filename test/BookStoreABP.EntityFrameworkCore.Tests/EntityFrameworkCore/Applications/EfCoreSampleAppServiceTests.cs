using BookStoreABP.Samples;
using Xunit;

namespace BookStoreABP.EntityFrameworkCore.Applications;

[Collection(BookStoreABPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreABPEntityFrameworkCoreTestModule>
{

}
