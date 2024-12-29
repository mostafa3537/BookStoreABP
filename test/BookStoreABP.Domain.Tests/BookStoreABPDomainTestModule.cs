using Volo.Abp.Modularity;

namespace BookStoreABP;

[DependsOn(
    typeof(BookStoreABPDomainModule),
    typeof(BookStoreABPTestBaseModule)
)]
public class BookStoreABPDomainTestModule : AbpModule
{

}
