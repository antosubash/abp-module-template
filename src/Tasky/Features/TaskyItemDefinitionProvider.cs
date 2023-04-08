using Volo.Abp.Features;

namespace MyCompanyName.MyProjectName.Features;

public class TaskyItemDefinitionProvider : FeatureDefinitionProvider
{
    public override void Define(IFeatureDefinitionContext context)
    {
        var taskyItemGroup = context.AddGroup(TaskyFeatures.GroupName);

        var myFeature1 = taskyItemGroup.AddFeature(TaskyFeatures.MyFeature1.Name, defaultValue: "true");
    }
}
