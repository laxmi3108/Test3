using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class TestVehicles
    {
        static void Main()
        {
            Car myCar = new Car();
            myCar.Drive();

            Sportscar mySportsCar = new Sportscar();
            mySportsCar.Drive();

            Van myVan = new Van();
            myVan.Drive();

            Minivan myMiniVan = new Minivan();
            myMiniVan.Drive();

            ExcursionVan myExcursionVan = new ExcursionVan();
            myExcursionVan.Drive();

            Console.ReadKey();
        }
    }

    
}
