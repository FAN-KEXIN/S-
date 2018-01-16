using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习1
{
   public class Vehicle
    {
       //型号
        private string Type;

        public string Type1
        {
            get { return Type; }
            set { Type = value; }
        }
       //产地
        private string Place;

        public string Place1
        {
            get { return Place; }
            set { Place = value; }
        }
       //构造函数
        public Vehicle(string type, string place)
        {
            this.Type = type;
            this.Place = place;
        }
       //VehicleRun()方法
        public void VehicleRun()
        {
            Console.WriteLine("汽车正在行驶！");
        }
    }
}
