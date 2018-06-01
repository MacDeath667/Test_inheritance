using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_inheritance;

namespace Test_inheritance
{
    public class CaterpillarMilitary
    {

        public int ArmorThickness { get; set; }

        public int Cost { get; set; }
        public int speed = 0;
        public int Speed { get; set; }
        public string Country { get; set; }

        public CaterpillarMilitary()
        {
            
                Console.WriteLine(GetType().Name + " - base class");
        
        }

    }
}

class Tank : CaterpillarMilitary
{
    public int Gun { get; set; }
    public Tank()
    {

        Console.WriteLine(GetType().Name + " - daughter class");

    }
}

class Artillery : CaterpillarMilitary
{
    public int ArtilleryGun { get; set; }
}

