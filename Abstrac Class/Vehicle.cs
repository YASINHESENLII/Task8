using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Class
{
    internal abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DriveTime { get; set; }//t
        public int DrivePath { get; set;}//s
        public DateTime ProductionDate { get; set;}

        public Vehicle()
        {

            ProductionDate = DateTime.Now;
        }
        

        public virtual int Averagespeed()
        {
             return DrivePath / DriveTime;
            

        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Factory Name: {FactoryName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Drive Time: {DriveTime} hours");
            Console.WriteLine($"Drive Path: {DrivePath} km");
            Console.WriteLine($"Production Date: {ProductionDate}");
        }


        public virtual string ToString()
    {
        return $"Factroyname:{FactoryName} Model :{Model}";

    }

    public abstract void DefineNatureHarmness();
    }
}
