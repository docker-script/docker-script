

using System.Text;
using DockerScript.Interface;
namespace DockerScript.StageSteps;


public static class WorkingDirEx {

    public static DockerStage WorkingDir(this DockerStage me, string wd)
    {
        me.CurrentWorkingDir = wd;
        me.Raw($"WORKDIR {wd}");
        return me;
    }

    public static DockerStage WorkingDir(this DockerStage me, string wd, Action<DockerStage> stage)
    {
        var c = me.CurrentWorkingDir;
        me.WorkingDir(wd);
        stage(me);
        me.WorkingDir(c);
        
        return me; 
    }

}
