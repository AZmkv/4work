namespace Lab4_2
{
    public class Network
    {
        private List<Computer> computers;

        public Network()
        {
            computers = new List<Computer>();
        }

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public void RemoveComputer(Computer computer)
        {
            computers.Remove(computer);
        }

        public void Connect(Computer computer1, Computer computer2)
        {
            IConnectable connectable1 = computer1 as IConnectable;
            IConnectable connectable2 = computer2 as IConnectable;

            if (connectable1 != null && connectable2 != null)
            {
                connectable1.Connect(computer2);
                connectable2.Connect(computer1);
            }
        }

        public void Disconnect(Computer computer1, Computer computer2)
        {
            IConnectable connectable1 = computer1 as IConnectable;
            IConnectable connectable2 = computer2 as IConnectable;

            if (connectable1 != null && connectable2 != null)
            {
                connectable1.Disconnect(computer2);
                connectable2.Disconnect(computer1);
            }
        }

        public void TransmitData(Computer fromComputer, Computer toComputer, string data)
        {
            Console.WriteLine($"Data from {fromComputer.IPAddress} to {toComputer.IPAddress}: {data}");
        }
    }

}
