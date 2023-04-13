namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[4];

            vehicles[0] = new Car() { FactoryName = "Toyota", Model = "Camry", Color = "Red", DoorCount = 4, IsElectricCar = false, DriveTime = 5, DrivePath = 150 };
            vehicles[1] = new Car() { FactoryName = "Tesla", Model = "Model S", Color = "Black", DoorCount = 4, IsElectricCar = true, DriveTime = 3.5, DrivePath = 200 };
            vehicles[2] = new Bicycle() { FactoryName = "Giant", Model = "Talon", Color = "Green", Type = "Mountain Bike", DriveTime = 2, DrivePath = 30 };
            vehicles[3] = new Bicycle() { FactoryName = "Scott", Model = "Contessa", Color = "Blue", Type = "Road Bike", DriveTime = 1.5, DrivePath = 40 };

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine("\n============================");
                Console.WriteLine(vehicle.ToString);
                Console.WriteLine("============================");
                vehicle.DefineNatureHarmness();
                Console.WriteLine($"Average Speed: {vehicle.AverageSpeed()} km/hour");
                vehicle.GetInfo();
            }
        }


        abstract class Vehicle
        {
            public string FactoryName { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double DriveTime { get; set; }
            public double DrivePath { get; set; }
            public readonly DateTime ProductionDate;

            public Vehicle()
            {
                ProductionDate = DateTime.Now;
            }

            public virtual void GetInfo()
            {
                Console.WriteLine($"Factory Name: {FactoryName}\nModel: {Model}\nColor: {Color}\nDrive Time: {DriveTime} hours\nDrive Path: {DrivePath} km");
            }

            public override string ToString()
            {
                return $"Factory Name: {FactoryName}\nModel: {Model}";
            }

            public abstract void DefineNatureHarmness();

            public double AverageSpeed()
            {
                return DrivePath / DriveTime;
            }
        }

        class Car : Vehicle
        {
            public int DoorCount { get; set; }
            public bool IsElectricCar { get; set; }

            public override void DefineNatureHarmness()
            {
                if (IsElectricCar)
                    Console.WriteLine("Nature Harmness: Low");
                else
                    Console.WriteLine("Nature Harmness: High");
            }
        }

        class Bicycle : Vehicle
        {
            public string Type { get; set; }

            public override void DefineNatureHarmness()
            {
                Console.WriteLine("Nature Harmness: None");
            }
        }


    }
}

