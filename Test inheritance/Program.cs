using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inheritance;

namespace Test_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tigerII = new Tank() { Cost = 16000000, ArmorThickness = 160, Country = "Germany", Gun = 54, Speed = 39 };
            Artillery su16 = new Artillery() { Cost = 420000, ArmorThickness = 24, Country = "USSR", ArtilleryGun = 68, Speed = 45 };
            tigerII.speed = 3214123;

            

            
            Console.ReadKey();
        }
    }
}
