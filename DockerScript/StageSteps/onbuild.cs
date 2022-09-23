

using System.Globalization;
using System.Text;
using DockerScript.Data;
using DockerScript.Interface;
namespace DockerScript.StageSteps;

public static class OnBuildEx {


    public static DockerStage OnBuild(this DockerStage me, string instruction)
    {
        return me.Raw($"ONBUILD {instruction}");
    }


    public static DockerStage OnBuild(this DockerStage me, Action<DockerStage> instructions)
    {
        var data = new DockerStage();
        instructions(data);
        me.StageSteps.Add(new OnBuildStep(data));
        return me;
    }

}

public class OnBuildStep : IStageStep
{
    private readonly DockerStage _instructions;

    public OnBuildStep(DockerStage instructions)
    {
        _instructions = instructions;
    }
    public string Build()
    {
        StringBuilder sb = new StringBuilder();
        foreach(var stage in _instructions.StageSteps)
        {
            sb.Append("ONBUILD ");
            sb.Append(stage.Build());
            sb.Append(Environment.NewLine);
        }
        return sb.ToString();
    }
}
