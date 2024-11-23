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
    public partial class medicalCare : Form
    {
        public medicalCare()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            var examForm = new PetsExamination();
            examForm.WindowState = FormWindowState.Maximized;
            examForm.FormClosed += (s, args) => this.Close();
            examForm.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void medicalCare_Load(object sender, EventArgs e)
        {

        }
    }
}
