namespace KubernetesScript.Extensions;

public static class ServiceNetworkEx
{
    public static ServiceNetwork OpenAll(this ServiceNetwork me, params short[] ports)
    {
        me.OpenPort(ports, NetWorkProtocol.ALL);
        return me;
    }
    
    public static ServiceNetwork OpenTcp(this ServiceNetwork me, params short[] ports)
    {
        me.OpenPort(ports, NetWorkProtocol.TCP);
        return me;
    }

    public static ServiceNetwork OpenUdp(this ServiceNetwork me, params short[] ports)
    {
        me.OpenPort(ports, NetWorkProtocol.UDP);
        return me;
    }
}