using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简答4
{
   public class BankCard
    {
        //银行卡号
        public string ID { get; set; }
        //密码
        public string Pwd { get; set; }
        //用户名
        public string Name { get; set; }
        //余额
        public double Money { get; set; }
        //虚方法
        public virtual double Bank(double mon)
        {
            double money = Money - mon;
            return money;
        }
       
    }
}
