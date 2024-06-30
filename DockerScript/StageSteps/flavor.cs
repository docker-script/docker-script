using System.Runtime.CompilerServices;
using DockerScript.Interface;

namespace DockerScript.StageSteps;


public class FlavorStep : IFluentInterface
{
    private Flavor _flavor;

    internal FlavorStep(Flavor flavor)
    {
        _flavor = flavor;
    }

    public FlavorStep AddDefault(DockerStage dockerStage)
    {
        _flavor.flavors.Add("", dockerStage);
        return this;
    }

    public FlavorStep AddFlavor(string name, DockerStage dockerStage)
    {
        _flavor.flavors.Add(name, dockerStage);
        return this;
    }

    public FlavorStep AddFlavor(string name, Action<DockerStage> dockerStage)
    {
        var stage = new DockerStage();
        dockerStage(stage);
        _flavor.flavors.Add(name, stage);
        return this;
    }

}

public class Flavor : IStageStep
{

    internal Dictionary<string, DockerStage> flavors = new Dictionary<string, DockerStage>();

    public string Build(BuildContext context)
    {
        if (flavors.ContainsKey(context.Flavor))
        { 
            return flavors[context.Flavor].Build(context);
        }
        return "";
    }
}
