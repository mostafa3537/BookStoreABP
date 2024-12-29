using Volo.Abp.Modularity;

namespace BookStoreABP;

public abstract class BookStoreABPApplicationTestBase<TStartupModule> : BookStoreABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
