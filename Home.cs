using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxproject
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btself_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(group1);
            group1.BringToFront();
            bunifuTransition1.ShowSync(group1);
        }

        private void btinvest_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(group2);
            group2.BringToFront();
            bunifuTransition1.ShowSync(group2);
        }

        private void btproperty_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(group3);
            group3.BringToFront();
            bunifuTransition1.ShowSync(group3);
        }

        private void btdonate_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(group4);
            group4.BringToFront();
            bunifuTransition1.ShowSync(group4);
        }

        private void bteconomy_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(group5);
            group5.BringToFront();
            bunifuTransition1.ShowSync(group5);
        }

        private void group13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
