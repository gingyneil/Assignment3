using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
          GiantPlanet myGiantPlanet = new GiantPlanet("Naboo",3.00,50000.00,"Gas");
        Console.WriteLine (myGiantPlanet.ToString());
        TerrestrialPlanet myTerrestrialPlanet = new TerrestrialPlanet(true,"Saturn",1000000000.00,40000000000);
        Console.WriteLine(myTerrestrialPlanet.ToString()); 
        waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
        }
    }
}
