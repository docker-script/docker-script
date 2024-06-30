using System.Text;
using DockerScript.Interface;

namespace DockerScript;

public class DockerStage: IFluentInterface
{

    public List<IStageStep> StageSteps { get; set; }
    public string CurrentWorkingDir { get; internal set; }
    public DockerStage()
    {
        StageSteps = new();
    }

    public string Build(BuildContext context)
    {
        StringBuilder sb = new StringBuilder();
        Console.WriteLine($"{StageSteps.Count}");
        foreach(var stage in StageSteps)
        {
            sb.Append(stage.Build(context));
            sb.Append(Environment.NewLine);
        }
        sb.Append(Environment.NewLine);
        return sb.ToString();
    }

}
