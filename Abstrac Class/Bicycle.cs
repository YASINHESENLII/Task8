using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Class
{
    internal class Bicycle:Vehicle
    {
        public string Type { get; init; }





        public override void DefineNatureHarmness()
        {
            
            Console.WriteLine($"Production Date: {ProductionDate}");
            Console.WriteLine($"{Model}: None");
            
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Type: {Type}");
        }
    }
}
