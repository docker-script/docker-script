namespace DockerScript.StageSteps;


public static class EntrypointEx
{
    public static DockerStage Entrypoint(this DockerStage me, params string[] command)
    {

        me.Raw((sb) => {
            sb.Append($"ENTRYPOINT [");
            foreach (var item in command)
            {
                sb.Append('"');
                sb.Append(item);
                sb.Append("\",");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(']');
        });
        return me;
    }
}