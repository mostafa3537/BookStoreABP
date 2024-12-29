using BookStoreABP.Samples;
using Xunit;

namespace BookStoreABP.EntityFrameworkCore.Domains;

[Collection(BookStoreABPTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreABPEntityFrameworkCoreTestModule>
{

}
