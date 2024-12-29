using BookStoreABP.Books;
using Xunit;

namespace BookStoreABP.EntityFrameworkCore.Applications.Books;

[Collection(BookStoreABPTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreABPEntityFrameworkCoreTestModule>
{

}