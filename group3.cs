using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxproject
{
    public partial class group3 : UserControl
    {
        public group3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = int.Parse(salary.Text);
            int o = int.Parse(Other.Text);
            int m = (s * 12) + o; //m คือ ค่ารายได้ทั้งหมด
            netmoney.Text = m.ToString();

            int a1 = 60000;
            int a2 = 0;
            int interest = int.Parse(numericUpDown1.Text);
            int price58 = int.Parse(textBox4.Text);
            int allpreduce = 0;
            int preduce4 = 0;
            int price62 = int.Parse(textBox5.Text);
            int preduce62 = 0;

            if (radioButton5.Checked || radioButton6.Checked)
            {
                a2 = 60000;
            }
            else if (radioButton4.Checked)
            {
                a2 = 0;
            }
            if(checkBox1.Checked)
            {
                groupBox3.Enabled = true;
                if (price58 < 3000000)
                {
                    allpreduce = ((price58 * 20) / 100);
                    textBox1.Text = allpreduce.ToString();
                    preduce4 = ((price58 * 4) / 100);
                    textBox2.Text = preduce4.ToString();
                }
            }
            else
            {
                groupBox3.Enabled = false;
            }

            if (checkBox2.Checked)
            {
                groupBox4.Enabled = true;
                if (price62 < 5000000)
                {
                    preduce62 = 200000;
                    textBox3.Text = preduce62.ToString();
                }
                else if (price62 < 200000)
                {
                    textBox3.Text = preduce62.ToString();
                }
            }
            else
            {
                groupBox4.Enabled = true;
            }
           

            ///รวมค่าลดหย่อน
            int t = a1 + a2 + interest + preduce4 + preduce62;
            deduction.Text = t.ToString();
            
            
            /////คำนวนภาษี
            int a = int.Parse(netmoney.Text); // a เก็บค่า รายได้ทั้งหมด
            int b = int.Parse(deduction.Text);// b เก็บค่า ค่าลดหย่อน
            int c;

            c = a - b;
            total.Text = c.ToString(); //c รายได้สุทธิ

            int x = int.Parse(total.Text); //สร้าง x เก็บค่า รายได้สุทธิ
            int tax1; //ภาษีที่ต้องจ่าย

            if (x > 5000001) //ถ้ารายได้สุทธิมากกว่า 5000001 
            {
                tax1 = (x * 35) / 100; //ภาษาที่ต้องจ่ายคือ 35% ของรายได้สุทธิ

                tax.Text = tax1.ToString();
            }
            else if (x >= 2000001)
            {
                tax1 = (x * 30) / 100;
                tax.Text = tax1.ToString();
            }
            else if (x >= 1000001)
            {
                tax1 = (x * 25) / 100;
                tax.Text = tax1.ToString();
            }
            else if (x >= 750001)
            {
                tax1 = (x * 20) / 100;
                tax.Text = tax1.ToString();
            }
            else if (x >= 500001)
            {
                tax1 = (x * 15) / 100;
                tax.Text = tax1.ToString();
            }
            else if (x >= 300001)
            {
                tax1 = (x * 10) / 100;
                tax.Text = tax1.ToString();
            }
            else if (x >= 150001)
            {
                tax1 = (x * 5) / 100;
                tax.Text = tax1.ToString();
            }
            else if (x <= 150000)
            {
                tax1 = 0;
                tax.Text = tax1.ToString();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox2.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupBox2.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int price58 = int.Parse(textBox4.Text);
             if (price58 > 3000000)
            {
                MessageBox.Show("ไม่สามารถลดหย่อนได้");
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
             else if (price58 < 3000000)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int price62 = int.Parse(textBox5.Text);
            if (price62 > 5000000)
            {
                MessageBox.Show("ไม่สามารถลดหย่อนได้");
                textBox3.Enabled = false;
            }
            else if (price62 < 3000000)
            {
                textBox3.Enabled = true;
                
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
        }
    }
}
