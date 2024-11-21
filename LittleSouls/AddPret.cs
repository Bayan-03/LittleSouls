using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.Entity.Migrations;

namespace LittleSouls
{
    public partial class AddPet : Form
    {
        littleSoulsEntities littleSouls = new littleSoulsEntities();
        public AddPet()
        {
            InitializeComponent();
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            pet NewPet = new pet()
            {
                petId = int.Parse(PetId.Text),
                petSex = PetGender.Text,
                petBreed = petBreed.Text,
                petSpecies = petspecies.Text,
                petColor = PetColor.Text,
                //petSetter = PetSetter.Text,
                dateOfArraival = Arival.Text,
                yearOfBirth = Birth.Text,
                //petImage = petPhoto.
            };
            littleSouls.pet.Add(NewPet);
            littleSouls.SaveChanges();
            MessageBox.Show("Anew Pet hass been added!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddPet_Load(object sender, EventArgs e)
        {

        }

        private void PetId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void petBreed_TextChanged(object sender, EventArgs e)
        {

        }

        private void Petgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void petspecies_TextChanged(object sender, EventArgs e)
        {

        }

        private void PetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PetId_KeyPress(object sender, KeyPressEventArgs e) /* id only number*/
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PetSetter_KeyPress(object sender, KeyPressEventArgs e) /*petsetter num*/
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void petspecies_KeyPress(object sender, KeyPressEventArgs e)    /*only text entery*/
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void petBreed_KeyPress(object sender, KeyPressEventArgs e) /*only text*/
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PetGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PetGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void clearForm_Click(object sender, EventArgs e)
        {
            PetId.Clear();
            petBreed.Clear();
            petspecies.Clear();
            //PetColor.
            PetSetter.Clear();
            //PetGender.

        }
    }
}
