using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习2
{
   public class Job
    {
       //工作名称
        public string Description { get; set; }
       //描述
        public string Name { get; set; }        
       //构造函数
        public Job(string name, string descrition)
        {
            this.Name = name;
            this.Description = descrition;
        }
    }
}
