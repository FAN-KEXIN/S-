using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简答3
{
    public  class Cat:Father
    {
        public Cat(string name,string color):base(name,color)
        {
           
        }
        public override void Bark()
        {
            string message = string.Format("我是{0}猫{1}",base.cloor,base.name);
            Console.WriteLine(message);
        }
    }
}
