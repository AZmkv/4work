namespace Lab4_2
{
    public interface IConnectable
    {
        void Connect(Computer computer);
        void Disconnect(Computer computer);
        void TransmitData(Computer sender, Computer receiver, string data);
    }
}
