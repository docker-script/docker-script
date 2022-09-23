

using System.Globalization;
using System.Text;
using DockerScript.Data;
using DockerScript.Interface;
namespace DockerScript.StageSteps;

public static class UserEx {


    public static DockerStage Copy(this DockerStage me, Chown chown)
    {

        return me.Raw(sb => {
            sb.Append("USER ");
            sb.Append(chown.User);
            if(chown.Group != null)
            {
                sb.Append(":");
                sb.Append(chown.Group);
            }
        });
    }


}
