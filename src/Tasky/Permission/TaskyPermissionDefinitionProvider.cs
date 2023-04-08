using Tasky.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Tasky.Permission;

public class TaskyPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var taskyGroup = context.AddGroup(TaskyPermissions.GroupName, L("Permission:Tasky"));
        var taskyItemPermission = taskyGroup.AddPermission(TaskyPermissions.TaskyItem.Default, L("Permission:TaskyItem"));
        taskyItemPermission.AddChild(TaskyPermissions.TaskyItem.Create, L("Permission:Create"));
        taskyItemPermission.AddChild(TaskyPermissions.TaskyItem.Update, L("Permission:Update"));
        taskyItemPermission.AddChild(TaskyPermissions.TaskyItem.Delete, L("Permission:Delete"));
    }
    
    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TaskyResource>(name);
    }
}