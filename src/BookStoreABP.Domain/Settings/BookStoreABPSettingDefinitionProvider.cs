using Volo.Abp.Settings;

namespace BookStoreABP.Settings;

public class BookStoreABPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreABPSettings.MySetting1));
    }
}
