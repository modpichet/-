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
    public partial class group1 : UserControl
    {
        public group1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }


        private void child2up_TextChanged(object sender, EventArgs e)
        {

        }


       

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void child_TextChanged(object sender, EventArgs e)
        {
            int a2 = int.Parse(child.Text);
            if (a2 > 2)
            {
                groupBox4.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox6.Enabled = true;
            }
            else if (radioButton2.Checked == false)
            {
                groupBox2.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupBox2.Enabled = false;
            }
        }

        private void group1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = int.Parse(salary.Text);
            int o = int.Parse(Other.Text);
            int m = (s * 12) + o; //m คือ ค่ารายได้ทั้งหมด
            netmoney.Text = m.ToString();


            int a1 = 60000; //ส่วนบุคคล
            int a2 = int.Parse(child.Text);
            int a2_1 = int.Parse(child2up.Text);
            int a3 = int.Parse(parent.Text);
            int a4 = int.Parse(parent1.Text);
            int a5 = int.Parse(disable.Text);
            int a6 = int.Parse(calve.Text);
            int a7 = 0;//คู่สมรสไม่มีรายได้ ได้เพิ่มอีก  60000


            if (radioButton5.Checked || radioButton6.Checked)
            {
                a7 = 60000;
            }
            else if (radioButton4.Checked)
            {
                a7 = 0;
            }


            if (a2 > 2 && a2_1 == 0)
            {
                a2 = int.Parse(child.Text);
                groupBox4.Enabled = true;
            }
            else if (a2 > 2 && a2_1 != 0)
            {
                a2 = 2;
                a2_1 = int.Parse(child2up.Text);
            }
            if (a6 > 60000)
            {
                a6 = 60000;
            }
            else if (a6 < 60000)
            {
                a6 = int.Parse(calve.Text);
            }



            int t = a1 + (a2 * 30000) + (a2_1 * 60000) + (a3 * 30000) + (a4 * 30000) + (a5 * 60000) + a6 + a7;
            deduction.Text = t.ToString();

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

        private void parent_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
