using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习4
{
    class OperationDive:Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0!");
            }
            double result = NumberA / NumberB;
            return result;
        }
    }
}
