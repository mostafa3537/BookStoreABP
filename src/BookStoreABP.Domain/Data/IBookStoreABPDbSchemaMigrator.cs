using System.Threading.Tasks;

namespace BookStoreABP.Data;

public interface IBookStoreABPDbSchemaMigrator
{
    Task MigrateAsync();
}
