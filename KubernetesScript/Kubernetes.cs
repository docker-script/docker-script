using KubernetesScript.Interface;
using KD = KubernetesScript.KubernetesData;
namespace KubernetesScript;

public class Kubernetes: IFluentInterface
{
    private List<Service> _services = new List<Service>();

    public Kubernetes AddService(Service service)
    {
        _services.Add(service);
        return this;
    }
    
    public Kubernetes AddService(Action<Service> service)
    {
        var item = new Service();
        service(item);
        return AddService(item);
    }

    public KD.Kubernetes[] Build()
    {
        var output = new List<KD.Kubernetes>();

        foreach (var service in _services)
        {
            output.Add(service.Build());
        }

        return output.ToArray();
    }

}
