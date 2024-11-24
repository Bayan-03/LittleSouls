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
    public partial class DonatsDp : Form
    {
        public DonatsDp()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var DonatsButton = new CEO();
            DonatsButton.WindowState = FormWindowState.Maximized;
            DonatsButton.FormClosed += (s, args) => this.Close();
            DonatsButton.Show();
        }
    }
}
