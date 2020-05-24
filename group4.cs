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
    public partial class group4 : UserControl
    {
        public group4()
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
            int ed = int.Parse(textBox1.Text);
            int hospital = int.Parse(textBox2.Text);
            int sport = int.Parse(textBox3.Text);
            int benefit = int.Parse(textBox4.Text);
            int flood = int.Parse(textBox5.Text);
            int general = int.Parse(textBox6.Text);
            int politics = int.Parse(numericUpDown1.Text);

            int t = a1 + a2 + (ed * 2) + (hospital * 2) + (sport * 2) + (benefit * 2) + (flood * 2) + (flood * 2) + politics;
            
            if (radioButton5.Checked || radioButton6.Checked)
            {
                a2 = 60000;
            }
            else if (radioButton4.Checked)
            {
                a2 = 0;
            }


            /////คำนวนภาษี
            int a = int.Parse(netmoney.Text); // a เก็บค่า รายได้ทั้งหมด
            int c;

            c = a - t;
            total.Text = c.ToString(); //c รายได้สุทธิ

            int d = (c * 10 / 100);
            deduction.Text = d.ToString();
            


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
            if(radioButton1.Checked == true)
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
    }
}
