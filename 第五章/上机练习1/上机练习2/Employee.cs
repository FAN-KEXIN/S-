using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 上机练习2
{
   public class Employee
    {
       //年龄
        public int Age { get; set; }
       //性别
        public Gender Gender { get; set; }
       //工号
        public string ID { get; set; }
       //姓名
        public string Name { get; set; }
       //添加工作属性列表
        protected List<Job> workList{ get; set; }
       //构造函数
        public Employee() { }
        public Employee(string id, int age, string name, Gender gender, List<Job> list)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
            this.workList = list;
        }

    }
}
