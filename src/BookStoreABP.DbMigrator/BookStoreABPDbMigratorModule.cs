using BookStoreABP.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookStoreABP.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreABPEntityFrameworkCoreModule),
    typeof(BookStoreABPApplicationContractsModule)
)]
public class BookStoreABPDbMigratorModule : AbpModule
{
}
