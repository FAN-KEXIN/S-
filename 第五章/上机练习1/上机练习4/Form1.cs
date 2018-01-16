using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 上机练习4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //计算按钮的事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text.Trim()))
            {
                MessageBox.Show("操作数不能为空！");
                this.textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.textBox2.Text.Trim()))
            {
                MessageBox.Show("操作数不能为空！");
                this.textBox2.Focus();
                return;
            }
            try
            {
                Operation opr = new Operation();
                switch (this.comboBox1.SelectedItem.ToString().Trim())
                {
                    case "+":
                            {
                                opr=new OperationAdd();
                                break;
                            }
                    case "-":
                            {
                                opr = new OperationGian();
                                break;
                            }
                    case "*":
                            {
                                opr = new OperationChen();
                                break;
                            }
                    case "/":
                            {
                                opr = new OperationDive();
                                break;
                            }
                    default:
                        break;
                }
                //设置参数与计算的数据
                opr.NumberA = double.Parse(this.textBox1.Text.Trim());
                opr.NumberB = double.Parse(this.textBox2.Text.Trim());
                //计算
                this.label2.Text = opr.GetResult().ToString();
                this.label1.Visible = true;
                this.label2.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
