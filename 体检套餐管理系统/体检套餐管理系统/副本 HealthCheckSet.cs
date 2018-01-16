using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检套餐管理系统
{
    public class HealthCheckSet
    {

        //HealthCheckItem的集合
        private string ltems;

        public string Ltems
        {
            get { return ltems; }
            set { ltems = value; }
        }
        //套餐价格
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //套餐名称
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       //保存套餐项目
        private List<HealthCheckItem> set = new List<HealthCheckItem>();

        public List<HealthCheckItem> Set
        {
            get { return set; }
            set { set = value; }
        } 

    }
}
