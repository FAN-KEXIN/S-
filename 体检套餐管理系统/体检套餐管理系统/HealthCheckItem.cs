using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检套餐管理系统
{
   public class HealthCheckItem
    {
       //项目描述
        private string description;
        Form1 a = new Form1();
        public HealthCheckItem() 
        {
            a.price = this;
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
       //项目名称
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       //项目价格
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //list泛型集合保存所有体检项目
        List<HealthCheckItem> AllItems = new List<HealthCheckItem>();
        //list泛型集合保存套餐体检项目
        List<HealthCheckItem> Ltem = new List<HealthCheckItem>();
        //计算套餐价格方法
        public void CalcPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in this.Ltem)
            {
                totalPrice += item.Price;
            }
            this.price = totalPrice;
        }
    }
}
