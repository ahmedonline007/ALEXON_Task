using ALEXON_Task.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ALEXON_Task.Permissions;

public class ALEXON_TaskPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ALEXON_TaskPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ALEXON_TaskPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ALEXON_TaskResource>(name);
    }
}
