using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简答3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Father> list = new List<Father>()
            {
               new Cat("ss","ss"),
               new Dog("dd","dd")
            };
            foreach (Father item in list)
            {
                item.Bark();
            }
            Console.ReadLine();
        }
        
    }
}
