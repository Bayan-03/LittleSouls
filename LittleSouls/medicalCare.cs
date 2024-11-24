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

        private void navBarPanel1_showHomeForm(object sender, EventArgs e)
        {
            this.Hide();
            var HomeForm = new Home();
            HomeForm.WindowState = FormWindowState.Maximized;
            HomeForm.FormClosed += (s, args) => this.Close();
            HomeForm.Show();
        }

        private void navBarPanel1_showMedicalCareForm(object sender, EventArgs e)
        {
            this.Hide();
            var medicalCareForm = new medicalCare();
            medicalCareForm.WindowState = FormWindowState.Maximized;
            medicalCareForm.FormClosed += (s, args) => this.Close();
            medicalCareForm.Show();
        }

        private void navBarPanel1_showPetsForm(object sender, EventArgs e)
        {
            this.Hide();
            var PetsForm = new Pets();
            PetsForm.WindowState = FormWindowState.Maximized;
            PetsForm.FormClosed += (s, args) => this.Close();
            PetsForm.Show();
        }
    }
}
