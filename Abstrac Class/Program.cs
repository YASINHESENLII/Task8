using System.ComponentModel.DataAnnotations;

namespace Abstrac_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
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
                FactoryName = "Gant",
                Model = "Taln",
                Color = "Red",
                DriveTime = 2,
                DrivePath = 100,
                Type = "Mountain Bike"
            };
            Vehicle[] vehicle = new Vehicle[] { car,bicycle };

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

