using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简答4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, BankCard> dic = new Dictionary<string, BankCard>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            textBox1.Focus();
            IntitData();
        }
        #region 实例化初始数据
        private void IntitData()
        {
            //本地卡
            BankBenCard localCard = new BankBenCard("123","123","123",123);
            //外地卡
            BankWeiCar otherCard = new BankWeiCar("234", "234", "234", 123);
            dic.Add(localCard.ID, localCard);
            dic.Add(otherCard.ID, otherCard);
        }
        #endregion
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("请输入卡号");
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("请输入密码");
                return;
            }
                string userCard = textBox3.Text;
                bool flag = dic.ContainsKey(userCard);
                if (flag)
                {
                    string pwd = textBox4.Text;

                    BankCard card = dic[userCard];


                    if (pwd.Equals(card.Pwd))
                    {
                        button1.Enabled = true;
                        button2.Enabled = true;
                        if (card is BankBenCard)
                        {
                            button3.Enabled = true;
                        }
                        label9.Text = userCard;
                        label8.Text = card.Name;
                        label10.Text = Convert.ToDouble(card.Money).ToString();
                    }
                    else
                    {
                        MessageBox.Show("密码不正确");
                    }
                }
                else
                {
                    MessageBox.Show("没有此卡");
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            string zhang = textBox3.Text;
            dic[zhang].Money = dic[zhang].Money - Convert.ToDouble(textBox5.Text);
            label10.Text = dic[zhang].Money.ToString();
            string zhang2 = textBox2.Text;
            dic[zhang2].Money = dic[zhang2].Money + Convert.ToDouble(textBox5.Text);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string zhang = textBox3.Text;
            dic[zhang].Money = dic[zhang].Money - Convert.ToDouble(textBox1.Text);
            label10.Text = dic[zhang].Money.ToString();
           
        }
        

      
    }
}
