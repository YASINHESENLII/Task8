using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Class
{
    internal class Car : Vehicle
    {


        
        public bool IsElectricCar { get;  set; }
        public int Doorcount { get;  init; }


        

        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine($"{Model}: Low car");
            }
            else
            {
                Console.WriteLine($"{Model}: High Car");
            }
        }

        public override void GetInfo()
        {

            Console.WriteLine($"Iselectriccar: {IsElectricCar}");
            Console.WriteLine($"Doorcount: {Doorcount}");
        }
    }

}
