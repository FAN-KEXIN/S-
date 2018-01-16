using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习4
{
    class OperationGian:Operation
    {
        public override double GetResult()
        {
            double result = NumberA -NumberB;

            return result;
        }
    }
}
