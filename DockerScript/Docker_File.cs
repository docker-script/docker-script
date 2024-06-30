using System.Numerics;
using System.Text;
using DockerScript.Interface;

namespace DockerScript;

public class DockerFile : IFluentInterface
{
    internal class _DockerStage
    {
        internal DockerStage Stage;
        internal string? Name;
        internal string baseImage;
        internal string flavor;
    }

    private List<_DockerStage> Stages { get; set; }

    public string? MainTag { get; set; }
    public List<string> Tags { get; set; }

    public DockerFile(string tag): this()
    {
        MainTag = tag;
    }

    public DockerFile()
    {
        Tags = new();
        Stages = new();
    }

    public DockerFile AddStage(string name, string baseImage, DockerStage stage, string flavor = "") {
        Stages.Add(new() {
            Name = name,
            baseImage = baseImage,
            Stage = stage,
            flavor = flavor
        });
        return this;
    }

    public DockerFile AddStage(string name, string baseImage, out DockerStage stageObject, Action<DockerStage> stage, string flavor = "") {
        var data = new DockerStage();
        stage(data);
        stageObject = data;
        return AddStage(name, baseImage, data);
    }
    
    public DockerFile AddStage(string name, string baseImage, Action<DockerStage> stage, string flavor = "") {
        var data = new DockerStage();
        stage(data);
        return AddStage(name, baseImage, data);
    }

    public DockerFile SingelStage(string baseImage, DockerStage stage, string flavor = "") {
        Stages.Add(new() {
            Name = null,
            baseImage = baseImage,
            Stage = stage,
            flavor = flavor
        });
        return this;
    }

    public DockerFile SingelStage(string baseImage, Action<DockerStage> stage, string flavor = "") {
        var data = new DockerStage();
        stage(data);
        return SingelStage(baseImage, data);
    }

    public string Build(BuildContext context)
    {
        StringBuilder sb = new();
        sb.AppendLine("# syntax=docker/dockerfile:1.2");
        Console.WriteLine("total steps {0}", Stages.Count);
        if(Stages.Count == 1)
        {
            var stage = Stages.First();
            sb.AppendLine($"FROM {stage.baseImage}");
            sb.Append(stage.Stage.Build(context));
        }
        else
        {
            foreach(var item in Stages)
            {
                if(item.flavor != context.Flavor) continue;
                sb.AppendLine($"FROM {item.baseImage} AS {item.Name}");
                sb.Append(item.Stage.Build(context));
            }
        }
        return sb.ToString();
    }

    public string[] Build(BuildContext baseContext, params string[] flavors)
    {

        var output = new List<string>();

        foreach (var flavor in flavors)
        {
            var context = baseContext;
            context.Flavor = flavor;
            output.Add(Build(context));
        }
        return output.ToArray();
    }

}

