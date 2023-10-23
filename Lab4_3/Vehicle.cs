namespace Lab4_3
{
    public class Vehicle : IDriveable
    {
        public string Type { get; set; }
        public double Speed { get; set; }
        public double Size { get; set; }

        public Vehicle(string type, double speed, double size)
        {
            Type = type;
            Speed = speed;
            Size = size;
        }

        public void Move()
        {
            Console.WriteLine($"{Type} is moving at {Speed} km/h.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} has stopped.");
        }
    }
}
