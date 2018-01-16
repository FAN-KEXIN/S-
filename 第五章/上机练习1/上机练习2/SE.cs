using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习2
{
    public class SE : Employee
    {
        public int popularity { get; set; }
        public  string SayHi()
        {
            string message = string.Format("大家好，我的工号为{0}，我的名字为{1}，我的人气值为{2}", this.ID, this.Name, this.popularity);
            return message;
        }
       
    }




}
