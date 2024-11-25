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
    public partial class Pets : Form
    {
        public Pets()
        {
            InitializeComponent();
        }

        private void Pets_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPetBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var AddPetForm = new AddPet();
            AddPetForm.WindowState = FormWindowState.Maximized;
            AddPetForm.FormClosed += (s, args) => this.Close();
            AddPetForm.Show();
        }

        private void AllPetsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var AllPetForm = new AllPet();
            AllPetForm.WindowState = FormWindowState.Maximized;
            AllPetForm.FormClosed += (s, args) => this.Close();
            AllPetForm.Show();
        }

        private void AdoptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdoptionForm = new Adoption();
            AdoptionForm.WindowState = FormWindowState.Maximized;
            AdoptionForm.FormClosed += (s, args) => this.Close();
            AdoptionForm.Show();
        }

        private void navBarPanel1_Load(object sender, EventArgs e)
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

        private void navBarPanel1_showPetsForm(object sender, EventArgs e)
        {
            this.Hide();
            var PetsForm = new Pets();
            PetsForm.WindowState = FormWindowState.Maximized;
            PetsForm.FormClosed += (s, args) => this.Close();
            PetsForm.Show();
        }

        private void navBarPanel1_showMedicalCareForm(object sender, EventArgs e)
        {
            this.Hide();
            var medicalCareForm = new medicalCare();
            medicalCareForm.WindowState = FormWindowState.Maximized;
            medicalCareForm.FormClosed += (s, args) => this.Close();
            medicalCareForm.Show();
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
