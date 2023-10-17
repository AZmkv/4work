using Lab4_1;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> soilTypes = new List<string> { "Clay", "Limestone", "Peat", "Black soil" };
            List<string> colors = new List<string> { "Broun", "Green", "Purple", "Red" };
            List<int> pulsesPerMinuteValues = new List<int> { 500, 600, 700, 800 };
            List<string> microorganismTypes = new()
            {
                "Fungi",
                "Bacteria",
                "Viruses",
                "Ainomycetes"
            };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Simulation {i + 1}:");
                Ecosystem ecosystem = new Ecosystem();

                Animal tiger = new Animal(90, 6, 1.2, "Tiger", 4, "Orange", 12.0);
                Animal puma = new Animal(85, 7, 1.1, "Puma", 4, "Brown", 11.0);

                foreach (var pulsesPerMinute in pulsesPerMinuteValues)
                {
                    foreach (var microorganismType in microorganismTypes)
                    {
                        Microorganism microorganism = new Microorganism(10, 1, 0.01, microorganismType, true, 0.5, pulsesPerMinute);
                        ecosystem.AddOrganism(microorganism);
                    }
                }

                foreach (var soilType in soilTypes)
                {
                    foreach (var color in colors)
                    {
                        Plant plant = new Plant(50, 2, 0.5, "Oak", color, soilType);
                        ecosystem.AddOrganism(plant);
                    }
                }
                ecosystem.AddOrganism(tiger);
                ecosystem.AddOrganism(puma);

                SimulateEcosystemRecursively(ecosystem, 5);
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void SimulateEcosystemRecursively(Ecosystem ecosystem, int iterations)
        {
            bool isNight = false;

            for (int i = 1; i <= iterations; i++)
            {
                Console.WriteLine($"Iteration {i}");
                Console.WriteLine($"Time of Day: {(isNight ? "Night" : "Day")}");
                ecosystem.SimulateEcosystem(isNight);


                isNight = !isNight;
            }
        }
    }
}