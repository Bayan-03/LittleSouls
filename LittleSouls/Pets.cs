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
    }
}
