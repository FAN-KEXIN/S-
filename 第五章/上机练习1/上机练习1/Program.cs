using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck("奥迪A6","德国");
            truck.VehicleRun();
            truck.TruckRun();
            Console.ReadLine();

        }
    }
}
