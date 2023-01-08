using LongLearn.Docker.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LongLearn.Docker.Permissions;

public class DockerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DockerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DockerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DockerResource>(name);
    }
}
