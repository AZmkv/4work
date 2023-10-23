using Lab4_2;

class Program
{
    static void Main()
    {
        Network network = new Network();

        Server server1 = new Server("192.168.0.1", 1000, "Windows Server");
        Server server2 = new Server("192.168.0.2", 1200, "Linux Server");
        Workstation workstation1 = new Workstation("192.168.0.3", 800, "Windows 10");
        Workstation workstation2 = new Workstation("192.168.0.4", 700, "MacOS");
        Router router1 = new Router("192.168.0.5", 500, "Cisco IOS");
        Router router2 = new Router("192.168.0.6", 600, "Juniper Junos");

        network.AddComputer(server1);
        network.AddComputer(server2);
        network.AddComputer(workstation1);
        network.AddComputer(workstation2);
        network.AddComputer(router1);
        network.AddComputer(router2);

        network.Connect(server1, workstation1);
        network.Connect(workstation1, router1);
        network.Connect(router1, server2);
        network.Connect(server2, router2);
        network.Connect(router2, workstation2);

        network.TransmitData(server1, workstation1, "Hello from Server 1 to Workstation 1");
        network.TransmitData(workstation1, server1, "Hello from Workstation 1 to Server 1");
        network.TransmitData(workstation1, server2, "Hello from Workstation 1 to Server 2");
        network.TransmitData(server2, workstation2, "Hello from Server 2 to Workstation 2");

        network.Disconnect(server1, workstation1);
        network.Disconnect(workstation1, router1);
        network.Disconnect(router1, server2);
        network.Disconnect(server2, router2);
        network.Disconnect(router2, workstation2);
    }
}