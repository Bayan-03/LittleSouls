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
    public partial class SalesDp : Form
    {
        public SalesDp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SalesDp_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var SalesButton = new CEO();
            SalesButton.WindowState = FormWindowState.Maximized;
            SalesButton.FormClosed += (s, args) => this.Close();
            SalesButton.Show();
        }
    }
}
