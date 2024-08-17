using Inspol.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Inspol.Permissions;

public class InspolPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(InspolPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(InspolPermissions.MyPermission1, L("Permission:MyPermission1"));
        var AgentsPermission = myGroup.AddPermission(InspolPermissions.Agents.Default, L("Permission:Agents"));
        AgentsPermission.AddChild(InspolPermissions.Agents.Create, L("Permission:Agents.Create"));
        AgentsPermission.AddChild(InspolPermissions.Agents.Edit, L("Permission:Agents.Edit"));
        AgentsPermission.AddChild(InspolPermissions.Agents.Delete, L("Permission:Agents.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InspolResource>(name);
    }
}
