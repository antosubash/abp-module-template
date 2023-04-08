using Volo.Abp.Settings;

namespace MyCompanyName.MyProjectName.Settings;

public class TaskySettingProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        context.Add(new SettingDefinition(TaskySettings.MySetting1, "My default value"));
    }
}