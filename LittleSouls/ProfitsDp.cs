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
    public partial class ProfitsDp : Form
    {
        public ProfitsDp()
        {
            InitializeComponent();
        }

        //private void guna2VProgressBar1_ValueChanged(object sender, EventArgs e)
        //{

        //}

        private void Profits_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var ProfitsButton = new CEO();
            ProfitsButton.WindowState = FormWindowState.Maximized;
            ProfitsButton.FormClosed += (s, args) => this.Close();
            ProfitsButton.Show();
        }
    }
}
