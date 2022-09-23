

using System.Globalization;
using System.Text;
using DockerScript.Data;
using DockerScript.Interface;
namespace DockerScript.StageSteps;

public static class CopyEx {

    static string GetChown(Chown? ch = null)
    {
        if(ch == null) return "";
        string g = (ch.Group == null)? ch.User: ch.Group;
        return $"--chown={ch.User}:{g}";
    }

    public static DockerStage Copy(this DockerStage me, string path, Chown? chown = null)
    {

        return me.Copy(path, path, chown);
    }

    public static DockerStage Copy(this DockerStage me, string to, string from, Chown? chown = null)
    {
        return me.Raw($"COPY {GetChown(chown)} {to} {from}");
    }

    public static DockerStage CopyFrom(this DockerStage me, string fromStage, string to, string from, Chown? chown = null)
    {
        return me.Raw($"COPY {GetChown(chown)} --from={fromStage} {to} {from}");
    }

}
