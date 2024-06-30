using System.Text;
using DockerScript.Interface;
namespace DockerScript.StageSteps;


public static class RawEx {

    public static DockerStage Raw(this DockerStage me, string command)
    {
        return me.Raw(sb => sb.Append(command));
    }

    public static DockerStage Raw(this DockerStage me, Action<StringBuilder> command)
    {
        var sb = new StringBuilder();
        command(sb);
        me.StageSteps.Add(new Raw(sb));
       return me; 
    }

}

public class Raw : IStageStep
{
    private readonly string command;

    public Raw(StringBuilder sb)
    {
        command = sb.ToString();
    }

    public string Build(BuildContext context)
    {
        return command;
    }
}