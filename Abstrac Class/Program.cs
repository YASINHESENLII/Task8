using System.ComponentModel.DataAnnotations;

namespace Abstrac_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle[] vehicles = new Vehicle[4];

            //vehicles[0] = new Car()
            //{
            //    FactoryName = "Bmw",
            //    Model = "M5",
            //    Color = "Black",
            //    Doorcount = 4,
            //    IsElectricCar = false,
            //    DriveTime = 5,
            //    DrivePath = 150
            //};
            //vehicles[1] = new Car()
            //{
            //    FactoryName = "Tesla",
            //    Model = "Model S",
            //    Color = "White",
            //    Doorcount = 4,
            //    IsElectricCar = true,
            //    DriveTime = 4,
            //    DrivePath = 200
            //};
            //vehicles[2] = new Bicycle()
            //{
            //    FactoryName = "Giiant",
            //    Model = "Talon",
            //    Color = "Green",
            //    DriveTime = 2,
            //    DrivePath = 30,
            //    Type = "Mountain Bike"
            //};
            //vehicles[3] = new Bicycle()
            //{
            //    FactoryName = "Scot",
            //    Model = "Contesa",
            //    Color = "Blue",
            //    DriveTime = 3,
            //    DrivePath = 40,
            //    Type = "Road Bike"
            //};

            //foreach (Vehicle vehicle in vehicles)
            //{

            //    foreach (Vehicle vehicle1 in vehicles)
            //    {
            //        Console.WriteLine("\n============================");
            //        Console.WriteLine(vehicle1);
            //        //Console.WriteLine("============================");
            //        //vehicle.DefineNatureHarmness();
            //        //Console.WriteLine($"Average Speed: {vehicle.Averagespeed()} km/hour");
            //        //vehicle.GetInfo();
            //    }
            //}
            Car car = new Car
            {
                FactoryName = "Bmw",
                Model = "M5",
                Color = "Black",
                DriveTime = 3,
                DrivePath = 300,
                Doorcount = 4,
                IsElectricCar = false

            };
            Bicycle bicycle = new Bicycle
            {
                FactoryName = "Giant",
                Model = "Talon",
                Color = "Blue",
                DriveTime = 2,
                DrivePath = 100,
                Type = "Mountain Bike"
            };
            Vehicle[] vehicle = new Vehicle[] { car };

            foreach (var item in vehicle)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");
            bicycle.GetInfo();
            car.GetInfo();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Bicycle speed:" + bicycle.Averagespeed());
            Console.WriteLine("Car speed:" + car.Averagespeed());
            Console.WriteLine("-------------------------");
            Console.WriteLine(bicycle.ToString());
            Console.WriteLine(car.ToString());
            Console.WriteLine("-------------------------");
            bicycle.DefineNatureHarmness();
            car.DefineNatureHarmness();
        }

    }
}

