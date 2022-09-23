using System.Text;
using DockerScript.Interface;
namespace DockerScript.StageSteps;


public static class RunEx {


    public static DockerStage RunFile(
        this DockerStage me,
        string path,
        string shell = StageSteps.Run.DefaultShell)
    {
        me.Raw($"# {path}");
        me.Run(
            shell,
            File.ReadAllText(path)
        );
        return me;
    }

    public static DockerStage Run(
        this DockerStage me,
        string command,
        string shell = StageSteps.Run.DefaultShell)
    {
        return me.Run(shell, sb => sb.Append(command));
    }

    public static DockerStage Run(this DockerStage me, Action<StringBuilder> command) => me.Run(StageSteps.Run.DefaultShell, command);


    public static DockerStage Run(this DockerStage me, string shell, Action<StringBuilder> command)
    {
        var sb = new StringBuilder();
        command(sb);
        me.StageSteps.Add(new Run(shell, sb));
        return me; 
    }

}

public class Run : IStageStep
{
    public const string DefaultShell = "/bin/bash";
    private readonly string _shell;
    private readonly string command;

    public Run(string shell, StringBuilder sb)
    {
        _shell = shell;
        command = sb.ToString();
    }

    public string Build()
    {
        var sb = new StringBuilder();
        sb.Append("RUN ");
        if(command.Contains('\n'))
        {
            sb.Append("<<EOT ");
            sb.Append(Environment.NewLine);
            sb.Append("#!");
            sb.Append(_shell);
            sb.Append(Environment.NewLine);
            sb.Append(command);
            sb.Append(Environment.NewLine);
            sb.Append("EOT");
        }
        else
        {
            sb.Append($"{_shell} {command}");
        }
        return sb.ToString();
    }
}