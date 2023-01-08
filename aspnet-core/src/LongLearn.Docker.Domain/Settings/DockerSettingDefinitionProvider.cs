using Volo.Abp.Settings;

namespace LongLearn.Docker.Settings;

public class DockerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DockerSettings.MySetting1));
    }
}
