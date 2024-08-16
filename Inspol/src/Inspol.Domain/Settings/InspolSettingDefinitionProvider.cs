using Volo.Abp.Settings;

namespace Inspol.Settings;

public class InspolSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(InspolSettings.MySetting1));
    }
}
