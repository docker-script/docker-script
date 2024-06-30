using DockerScript;
using KubernetesScript.Interface;
using KD = KubernetesScript.KubernetesData;
namespace KubernetesScript;

public class Service: IFluentInterface
{

    public ServiceNetwork Network { get; private set; }

    public int Replicas { get; set; }

    public string? Tag {
        get {
            if (docker != null)
            {
                return docker.MainTag;
            }
            return containerTag;
        }
    }

    private DockerFile? docker;
    public string? containerTag;

    
    internal Service(ServiceNetwork network) {
        Network = network;
    }
    
    internal  Service() {
        Network = new ServiceNetwork();
    }

    public Service UseDockerFile(DockerFile dockerFile)
    {
        docker = dockerFile;
        containerTag = null;
        return this;
    }

    public Service UseTag(string containerTag)
    {
        this.containerTag = containerTag;
        docker = null;
        return this;
    }

    
    public Service AddLabel(string key, string value)
    {
        
        return this;
    }
    
    public Service AddLabel(string label)
    {
        return AddLabel(label, string.Empty);
    }

    public KD.Kubernetes Build()
    {
        return new KD.Kubernetes()
        {
            ApiVersion = KD.ApiVersion.AppsV1
        };
    }

}
