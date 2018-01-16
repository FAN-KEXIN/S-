using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简答3
{
   public class Dog:Father
    {

       public Dog(string name, string color):base(name,color)
       {
           
       }
       public override void Bark()
       {
           string message = string.Format("我是{0}狗{1}，汪汪！", base.name, base.cloor);
           Console.WriteLine(message);
       }
    }
}
