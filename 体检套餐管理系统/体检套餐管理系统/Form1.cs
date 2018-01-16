using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 体检套餐管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //list泛型集合
        List<HealthCheckItem> item = new List<HealthCheckItem>();
        
        List<HealthCheckItem> items = new List<HealthCheckItem>();
        //创建对象接受检查项
        HealthCheckSet heal;
        public HealthCheckItem price;
        private void Form1_Load(object sender, EventArgs e)
        {
            Realize();
           
        }
        public void CalcPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem i in item)
            {
                totalPrice += i.Price;
            }
            this.label7.Text = totalPrice.ToString();
        }
        //入学体检套餐
        public void Realize()
        {
            HealthCheckItem hea = new HealthCheckItem();           
            hea.Price = 50;
            hea.Name = "肝功能";
            hea.Description = "用于检查肝功能";
            item.Add(hea);
            items.Add(hea);
            HealthCheckItem hea1 = new HealthCheckItem();
            hea1.Price = 5;
            hea1.Name = "身高";
            hea1.Description = "用于检查身高";
            item.Add(hea1);
            items.Add(hea1);
            HealthCheckItem hea2 = new HealthCheckItem();
            hea2.Price = 5;
            hea2.Name = "体重";
            hea2.Description = "用于检查体重";
            item.Add(hea2);
            items.Add(hea2);
            HealthCheckItem hea3 = new HealthCheckItem();
            hea3.Price = 30;
            hea3.Name = "B超";
            hea3.Description = "用于检查B超";
            item.Add(hea3);
            items.Add(hea3);
            HealthCheckItem hea111 = new HealthCheckItem();
            hea111.Price = 50;
            hea111.Name = "视力";
            hea111.Description = "用于检查视力";
            item.Add(hea111);
            items.Add(hea111);
            HealthCheckItem hea1121 = new HealthCheckItem();
            hea1121.Price = 50;
            hea1121.Name = "心电图";
            hea1121.Description = "用于检查心电图";
            item.Add(hea1121);
            items.Add(hea1121);
        }
        //套餐列表
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string xia=comboBox1.Text;
            if ( xia== "请选择")
            {
                this.dataGridView1.DataSource = new BindingList<HealthCheckItem>();
                label5.Text = "";
                label7.Text = "";
                return;
            }
            else
            {
                this.dataGridView1.DataSource = new BindingList<HealthCheckItem>();
               
            }
            //设置套餐名
            label5.Text=this.comboBox1.Text;
            CalcPrice();            
            HealthCheckItem health = new HealthCheckItem();
           this.dataGridView1.DataSource =new BindingList<HealthCheckItem>(item);

        }

        //套餐名添加按钮
        private void button1_Click(object sender, EventArgs e)
        {
            HealthCheckSet ss = new HealthCheckSet();
           string number=textBox1.Text;
           for (int i = 0; i < items.Count; i++)
           {
               ss.Name = number;
               //items.Add(ss);             
           }
           comboBox1.Items.Add(number);
          
        }
        //套餐列表添加
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < item.Count; i++)
            {
          
                if (item[i].Name == comboBox2.Text)
                {
                    MessageBox.Show("你已经有此项目了");
                    break;
                }
                else
                {

                    //foreach (HealthCheckSet itemaa in set.Ltems)
                    //{
                        
                    //}
                }
               
            }
            item.Add(items[comboBox2.SelectedIndex]);
            //this.dataGridView1.DataSource = new BindingList<HealthCheckItem>();
        }
        //刷新dgv数据
        public void BindGrid(List<HealthCheckSet> list)
        {
            this.dataGridView1.DataSource = new BindingList<HealthCheckSet>(list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string num = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            MessageBox.Show(num);
            for (int i = 0; i < item.Count; i++)
            {
                if (num==item[i].Name)
                {
                    item.Remove(item[i]);
                    break;
                }
            }
            this.dataGridView1.DataSource = new BindingList<HealthCheckItem>(item);
        }
    }
}
