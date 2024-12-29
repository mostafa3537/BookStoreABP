using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookStoreABP.Data;

/* This is used if database provider does't define
 * IBookStoreABPDbSchemaMigrator implementation.
 */
public class NullBookStoreABPDbSchemaMigrator : IBookStoreABPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
