using Volo.Abp.Features;

namespace Tasky.Features;

public class TaskyItemDefinitionProvider : FeatureDefinitionProvider
{
    public override void Define(IFeatureDefinitionContext context)
    {
        var taskyItemGroup = context.AddGroup(TaskyFeatures.GroupName);

        var myFeature1 = taskyItemGroup.AddFeature(TaskyFeatures.MyFeature1.Name, defaultValue: "true");
    }
}
