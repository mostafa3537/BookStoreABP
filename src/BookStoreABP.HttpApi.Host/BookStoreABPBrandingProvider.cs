using Microsoft.Extensions.Localization;
using BookStoreABP.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookStoreABP;

[Dependency(ReplaceServices = true)]
public class BookStoreABPBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookStoreABPResource> _localizer;

    public BookStoreABPBrandingProvider(IStringLocalizer<BookStoreABPResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
