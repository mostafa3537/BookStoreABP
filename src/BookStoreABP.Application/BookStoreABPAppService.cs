using BookStoreABP.Localization;
using Volo.Abp.Application.Services;

namespace BookStoreABP;

/* Inherit your application services from this class.
 */
public abstract class BookStoreABPAppService : ApplicationService
{
    protected BookStoreABPAppService()
    {
        LocalizationResource = typeof(BookStoreABPResource);
    }
}
