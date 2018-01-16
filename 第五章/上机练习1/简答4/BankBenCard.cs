using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简答4
{
    public class BankBenCard:BankCard
    {
        public BankBenCard(){}
        public BankBenCard(string id, string pwd, string name, double money)
       {
           this.ID=id;
           this.Pwd=pwd;
           this.Name = name;
           this.Money = money;
       }
       public override double Bank(double mon)
       {
           double money = this.Money - mon;
           return money;
       }
    }
}
