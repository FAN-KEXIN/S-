using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简答3
{
   public class Father
    {


       public Father(string name, string cloor)
       {
           this.name = name;
           this.cloor = cloor;
       }

        public string name { get; set; }
        public string cloor { get; set; }

        public virtual void Bark()
        {
            Console.WriteLine("asdfghjk");
        }

    }
}
