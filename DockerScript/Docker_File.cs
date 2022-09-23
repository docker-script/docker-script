using System.Text;
using DockerScript.Interface;

namespace DockerScript;

public class DockerFile : IFluentInterface
{
    internal class _DockerStage {
        internal DockerStage Stage;
        internal string? Name;
        internal string baseImage;
    }

    private List<_DockerStage> Stages { get; set; }

    public DockerFile()
    {
        Stages = new();
    }

    public DockerFile AddStage(string name, string baseImage, DockerStage stage) {
        Stages.Add(new() {
            Name = name,
            baseImage = baseImage,
            Stage = stage
        });
        return this;
    }

    public DockerFile AddStage(string name, string baseImage, Action<DockerStage> stage) {
        var data = new DockerStage();
        stage(data);
        return AddStage(name, baseImage, data);
    }

    public DockerFile SingelStage(string baseImage, DockerStage stage) {
        Stages.Add(new() {
            Name = null,
            baseImage = baseImage,
            Stage = stage
        });
        return this;
    }

    public DockerFile SingelStage(string baseImage, Action<DockerStage> stage) {
        var data = new DockerStage();
        stage(data);
        return SingelStage(baseImage, data);
    }

    public string Build()
    {
        StringBuilder sb = new();
        sb.AppendLine("# syntax=docker/dockerfile:1.2");
        if(Stages.Count == 1)
        {
            var stage = Stages.First();
            sb.AppendLine($"FROM {stage.baseImage}");
            sb.Append(stage.Stage.Build());
        }
        else
        {
            foreach(var item in Stages)
            {
                sb.AppendLine($"FROM {item.baseImage} AS {item.Name}");
                sb.Append(item.Stage.Build());
            }
        }
        return sb.ToString();
    }

}