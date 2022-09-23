

using System.Globalization;
using System.Text;
using DockerScript.Data;
using DockerScript.Interface;
namespace DockerScript.StageSteps;

public static class HealthCheckEx {

    public static DockerStage HealthCheck(this DockerStage me, 
        string command, 
        TimeSpan? interval = null,
        TimeSpan? timeout = null,
        TimeSpan? startPeriod = null,
        int? retries = null
    )
    {

        return me.Raw(sb => {
            sb.Append("HEALTHCHECK ");
            if(interval.HasValue)
                sb.Append($" --interval={interval.Value.TotalSeconds}s");
            if(timeout.HasValue)
                sb.Append($" --timeout={timeout.Value.TotalSeconds}s");
            if(startPeriod.HasValue)
                sb.Append($" --start-period={startPeriod.Value.TotalSeconds}s");
            if(retries.HasValue)
                sb.Append($" --retries={retries.Value}");
            
            sb.Append("RUN ");
            sb.Append(command);
        });
    }

    public static DockerStage HttpHealthCheck(this DockerStage me, 
        string uri, 
        TimeSpan? interval = null,
        TimeSpan? timeout = null,
        TimeSpan? startPeriod = null,
        int? retries = null
    )
    {
        return me.HealthCheck(
            $"curl -f {uri} || exit 1",
            interval,
            timeout,
            startPeriod,
            retries
        );
    }
}
