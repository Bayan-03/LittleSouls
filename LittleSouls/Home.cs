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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Petsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var PetForm = new Pets();
            PetForm.WindowState = FormWindowState.Maximized;
            PetForm.FormClosed += (s, args) => this.Close();
            PetForm.Show();
        }

        private void Invoicesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var invoiceForm = new TFo();
            invoiceForm.WindowState = FormWindowState.Maximized;
            invoiceForm.FormClosed += (s, args) => this.Close();
            invoiceForm.Show();
        }

        private void MedicalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var MedicalForm = new medicalCare();
            MedicalForm.WindowState = FormWindowState.Maximized;
            MedicalForm.FormClosed += (s, args) => this.Close();
            MedicalForm.Show();
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
        private void navBarPanel1_showInvoiceForm(object sender, EventArgs e)
        {
            this.Hide();
            var InvoiceForm = new TFo();
            InvoiceForm.WindowState = FormWindowState.Maximized;
            InvoiceForm.FormClosed += (s, args) => this.Close();
            InvoiceForm.Show();
        }
    }
}
