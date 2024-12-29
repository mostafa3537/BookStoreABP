using Volo.Abp.Modularity;

namespace BookStoreABP;

/* Inherit from this class for your domain layer tests. */
public abstract class BookStoreABPDomainTestBase<TStartupModule> : BookStoreABPTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
