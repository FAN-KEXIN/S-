using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习2
{
   public class PM:Employee
    {
       //阅历
        public int _yearOfExperience { get; set; }
        public  string SayHi()
        {
            string message = string.Format("大家好，我的工号为{0}，我的名字为{1}，我的阅历为{2}", this.ID, this.Name, this._yearOfExperience);
            return message;

        }
       
    }
}
