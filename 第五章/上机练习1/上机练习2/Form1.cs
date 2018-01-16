using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 上机练习2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //员工集合
        List<Employee> empls = new List<Employee>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        public void Init()
        {
            //实例化SE对象
            List<Job> list1 = new List<Job>();
            list1.Add(new Job("编码","购物车模块"));
            list1.Add(new Job("测试","给购物车模块做单元测试"));
            SE ai = new SE();
            ai.ID = "qqq";
            ai.Name = "爱变成";
            ai.Gender = Gender.男;
            ai.popularity = 20;
            List<Job> list2 = new List<Job>();
            list2.Add(new Job("设计","数据库建设"));
            list2.Add(new Job("编写文档","详细设计说明书"));
            SE joe = new SE();
            joe.ID = "qq";
            joe.Name = "变成";
            joe.Gender = Gender.女;
            joe.popularity = 30;
            PM pm=new PM();
            pm.ID = "5678";
            pm.Name = "盖茨";
            pm.Age = 45;
            pm.Gender = Gender.男;
            empls.Add(ai);
            empls.Add(joe);
            empls.Add(pm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in empls)
            {
                if (emp is PM)
                {
                    MessageBox.Show(((PM)emp).SayHi(), "汇报");
                }
                if (emp is SE)
                {
                    MessageBox.Show(((SE)emp).SayHi(), "汇报");
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
         
           
        }
    }
}
