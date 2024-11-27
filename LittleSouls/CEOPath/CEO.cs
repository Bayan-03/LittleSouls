using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSouls
{
    public partial class CEO : Form
    {
        public CEO()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var DonatsDpForm = new DonatsDp();
            DonatsDpForm.WindowState = FormWindowState.Maximized;
            DonatsDpForm.FormClosed += (s, args) => this.Close();
            DonatsDpForm.Show();
        }

        private void DepButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var DepartsDpForm = new DepartsDp();
            DepartsDpForm.WindowState = FormWindowState.Maximized;
            DepartsDpForm.FormClosed += (s, args) => this.Close();
            DepartsDpForm.Show();
        }

        private void ProButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            var ProfitsDpForm = new ProfitsDp();
            ProfitsDpForm.WindowState = FormWindowState.Maximized;
            ProfitsDpForm.FormClosed += (s, args) => this.Close();
            ProfitsDpForm.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            var SalesDpForm = new SalesDp();
            SalesDpForm.WindowState = FormWindowState.Maximized;
            SalesDpForm.FormClosed += (s, args) => this.Close();
            SalesDpForm.Show(); 
        }
    }
}
