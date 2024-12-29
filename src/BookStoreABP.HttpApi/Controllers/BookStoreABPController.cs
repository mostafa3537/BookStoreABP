using BookStoreABP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookStoreABP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreABPController : AbpControllerBase
{
    protected BookStoreABPController()
    {
        LocalizationResource = typeof(BookStoreABPResource);
    }
}
