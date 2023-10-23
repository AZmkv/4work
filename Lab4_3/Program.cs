using Lab4_3;

class Program
{
    static void Main()
    {
        Road road1 = new Road(10.0, 3.0, 2);
        Road road2 = new Road(15.0, 4.0, 3);

        Vehicle car = new Vehicle("Car", 60.0, 4.5);
        Vehicle truck = new Vehicle("Truck", 50.0, 8.0);
        Vehicle bus = new Vehicle("Bus", 55.0, 12.0);

        road1.TrafficLevel = 30.0;
        road2.TrafficLevel = 50.0;

        TrafficSimulation.Simulate(road1, car);
        Console.WriteLine();

        TrafficSimulation.Simulate(road1, truck);
        Console.WriteLine();

        TrafficSimulation.Simulate(road2, bus);
    }
}
