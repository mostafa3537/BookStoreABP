using Volo.Abp.Modularity;

namespace BookStoreABP;

[DependsOn(
    typeof(BookStoreABPApplicationModule),
    typeof(BookStoreABPDomainTestModule)
)]
public class BookStoreABPApplicationTestModule : AbpModule
{

}
