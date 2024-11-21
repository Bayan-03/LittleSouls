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
    public partial class Adoption : Form
    {
        littleSoulsEntities littleSouls2 = new littleSoulsEntities();
        public Adoption()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void invoicbtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Adoption_Load(object sender, EventArgs e)
        {

        }

        private void Adoptbtn_Click(object sender, EventArgs e)
        {
            pet adopt = new pet()
            {
                petId = int.Parse(PetID.Text),
                //petSex = Gendercheck.,
                petBreed = BreedTextBox.Text,
                petSpecies = SpeciesTextbox.Text,
                petColor = PetColor.Text,
            };
            customer adopter = new customer()
            {
                customerId = int.Parse(OwnerIDTextBox.Text),
                firstName = ClientNameTextBox.Text,
                phoneNumber = int.Parse(PhoneTextBox.Text),

            };
        }
    }
}
