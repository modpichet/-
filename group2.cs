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
    public partial class group2 : UserControl
    {
        public group2()
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
            int a3 = int.Parse(numericUpDown1.Text);
            int a4 = int.Parse(numericUpDown2.Text);
            int a5 = 0;
            int a6 = int.Parse(numericUpDown4.Text);
            int a7 = int.Parse(numericUpDown5.Text);
            int a8 = int.Parse(numericUpDown6.Text);
            int a9 = int.Parse(numericUpDown7.Text);
            

            if ((a4 + a5) >= 100000)
            {
                a5 = 15000;
            }
            else if (a5 >= 15000)
            {
                a5 = 15000;
            }
            else if (a5 < 15000)
            {
                a5 = int.Parse(numericUpDown3.Text);
            }

            //ค่าลดหย่อนจากคู่สมรสที่ไม่มีรายได้ 60,000 บาท
            if (radioButton5.Checked || radioButton6.Checked)
            {
                a2 = 60000;
            }
            else if (radioButton4.Checked)
            {
                a2 = 0;
            }


            int t = a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9;
            deduction.Text = t.ToString();//รวมค่าลดหย่อน

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
                numericUpDown5.Enabled = false;
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

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                numericUpDown5.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                numericUpDown5.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked == true)
            {
                numericUpDown5.Enabled = false;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void tax_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void deduction_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
