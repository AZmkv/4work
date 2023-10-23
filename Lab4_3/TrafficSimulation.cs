namespace Lab4_3
{
    public class TrafficSimulation
    {
        public static void Simulate(Road road, Vehicle vehicle)
        {
            double trafficMultiplier = road.TrafficLevel / 100.0;
            double adjustedSpeed = vehicle.Speed * (1 - trafficMultiplier);

            Console.WriteLine($"Traffic level: {road.TrafficLevel}%");
            Console.WriteLine($"Original speed: {vehicle.Speed} km/h");
            Console.WriteLine($"Adjusted speed: {adjustedSpeed} km/h");

            vehicle.Move();
            vehicle.Stop();
        }
    }
}
