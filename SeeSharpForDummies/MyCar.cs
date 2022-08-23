
namespace SeeSharpForDummies
{
    public class MyCar
    {
        private string model { get; set; } // Name of the model
        private string manufacturer { get; set; } // Ditto
        private int numOfDoors { get; set; } // You get the idea.
        private Motor motor { get; set; }
        private static int numberOfCars { get; set; }
        private const string factoryName = "Mighty Car Factory";

        public MyCar()
        {
            numberOfCars++;
        }

        static void Main(string[] args)
        {
            MyCar myCar = new()
            {
                manufacturer = "Jeep",
                model = "Cherokee",
                numOfDoors = 4,
                motor = new()
                {
                    power = 230,
                    displacement = 4.0
                }

            };

            MyCar myCar2 = new()
            {
                manufacturer = "Jeep",
                model = "Grande",
                numOfDoors = 4,
                motor = new()
                {
                    power = 250,
                    displacement = 4.0
                }

            };
            Console.WriteLine("Number of cars built till now: " + MyCar.numberOfCars);
            Console.WriteLine($"Your vehicle is a {myCar.manufacturer} {myCar.model} with {myCar.numOfDoors} doors, using a {myCar.motor.displacement} liter engine producing {myCar.motor.power}hp.");
            Console.WriteLine("Car factory name: " + MyCar.factoryName);
        }
    }

    public class Motor
    {
        public int power { get; set; } // Power of the motor [horsepower]
        public double displacement { get; set; } // Engine displacement [liter]
    }
}
