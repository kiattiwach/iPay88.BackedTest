using iPay88.BackedTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace iPay88.BackedTest.Permissions;

public class BackedTestPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BackedTestPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BackedTestPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BackedTestResource>(name);
    }
}
