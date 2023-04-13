namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // create some vehicle objects
            var car1 = new Car(new DateTime(2021, 1, 1), 4, true)
            {
                FactoryName = "Tesla",
                Model = "Model S",
                Color = "Red",
                DriveTime = 4,
                DrivePath = 400
            };

            var car2 = new Car(new DateTime(2022, 2, 2), 2, false)
            {
                FactoryName = "Ford",
                Model = "Mustang",
                Color = "Yellow",
                DriveTime = 2,
                DrivePath = 200
            };

            var bicycle1 = new Bicycle(new DateTime(2023, 3, 3), "Mountain")
            {
                FactoryName = "Giant",
                Model = "Anthem",
                Color = "Blue",
                DriveTime = 1,
                DrivePath = 10
            };

            // put them in an array
            Vehicle[] vehicles = { car1, car2, bicycle1 };

            // print out each vehicle using a foreach loop
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
                vehicle.GetInfo();
                Console.WriteLine();
            }
        }
    }
    
    

abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public DateTime ProductionDate { get; }

        public Vehicle(DateTime productionDate)
        {
            ProductionDate = productionDate;
        }

        public abstract void DefineNatureHarmness();

        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory Name: {FactoryName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Drive Time: {DriveTime}");
            Console.WriteLine($"Drive Path: {DrivePath}");
            Console.WriteLine($"Production Date: {ProductionDate.ToShortDateString()}");
            Console.WriteLine($"Average Speed: {AverageSpeed()} km/h");
            DefineNatureHarmness();
        }

        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }

        public double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }

    class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }

        public Car(DateTime productionDate, int doorCount, bool isElectricCar)
            : base(productionDate)
        {
            DoorCount = doorCount;
            IsElectricCar = isElectricCar;
        }

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine("Nature harmness: low");
            }
            else
            {
                Console.WriteLine("Nature harmness: high");
            }
        }
    }

    class Bicycle : Vehicle
    {
        public string Type { get; set; }

        public Bicycle(DateTime productionDate, string type)
            : base(productionDate)
        {
            Type = type;
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("Nature harmness: none");
        }
    }

    
    
        
    }





