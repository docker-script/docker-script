namespace DockerScript.Data;

public class Chown
{
    public string User { get; set; }
    public string? Group { get; set; }
    public static implicit operator Chown(string user)
    {
        var data = user.Split(":");

        return new() {
            User = data[0],
            Group = (data.Length == 2)? data[1]: null
        };
    }

}