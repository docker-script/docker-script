using KubernetesScript.Interface;

using KD = KubernetesScript.KubernetesData;

namespace KubernetesScript;

public enum NetWorkProtocol
{ 
    TCP,
    UDP,
    ALL
}

public class ServiceNetwork: IFluentInterface
{

    public Dictionary<short, NetWorkProtocol> Ports = new();

    
    public ServiceNetwork OpenPort(IEnumerable<short> ports, NetWorkProtocol networkProtocol)
    {
        foreach (var port in ports)
        {
            OpenPort(port, networkProtocol);
        }
        return this;
    }
    
    public ServiceNetwork OpenPort(short port, NetWorkProtocol networkProtocol)
    {
        Ports.Add(port, networkProtocol);
        return this;
    }

    public ServiceNetwork()
    { 

    }

    internal void Build()
    {
        
    }

}
