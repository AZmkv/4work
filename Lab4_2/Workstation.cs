using System.Net;

namespace Lab4_2
{
    public class Workstation : Computer, IConnectable
    {
        public Workstation(string ipAddress, int power, string osType) : base(ipAddress, power, osType)
        {
        }

        public void Connect(Computer computer)
        {
            Console.WriteLine($"Connected {IPAddress} to {computer.IPAddress}");
        }

        public void Disconnect(Computer computer)
        {
            Console.WriteLine($"Disconnected {IPAddress} from {computer.IPAddress}");
        }

        public void TransmitData(Computer sender, Computer receiver, string data)
        {
            Console.WriteLine($"Data from {sender.IPAddress} to {receiver.IPAddress}: {data}");
        }
    }
}
