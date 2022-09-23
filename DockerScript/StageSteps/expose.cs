

using System.Text;
using DockerScript.Interface;
namespace DockerScript.StageSteps;


public static class ExposeEx {

    public static DockerStage Expose(this DockerStage me, short port)
    {
        return me.Raw($"EXPOSE {port}");
    }

    public static DockerStage Expose(this DockerStage me, params short[] ports)
    {
        foreach (var port in ports)
        {
            me.Expose(port);
        }
        return me; 
    }

}
