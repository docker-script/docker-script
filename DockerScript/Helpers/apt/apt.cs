using System.Globalization;
using DockerScript.StageSteps;
namespace DockerScript.Hekpers.apt;

public static class Apt {
    public static DockerStage AptInstall(this DockerStage me, params string[] package)
    {
        me.Run($@"apt -q update && apt install -y {string.Join(' ', package)} && rm -rf /var/lib/apt/lists/*");
        return me;
    }
}