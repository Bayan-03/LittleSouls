﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LittleSouls
{
    public partial class AddPet : Form
    {
        littleSoulsEntities littleSouls = new littleSoulsEntities();

        public AddPet()
        {
            InitializeComponent();
        }





        private void AddPet_Load(object sender, EventArgs e) {
        }

        private void Adoptbtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Gendercheck_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PetID_TextChanged(object sender, EventArgs e)
        {

        }

        private void PetColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            
                // تحقق من الحقول المطلوبة
                if (string.IsNullOrEmpty(petgender.Text) ||
                    string.IsNullOrEmpty(speciestxt.Text) ||
                    string.IsNullOrEmpty(PetColor.Text) ||
                    string.IsNullOrEmpty(health.Text) ||
                    string.IsNullOrEmpty(BreedCombo.Text) ||
                    string.IsNullOrEmpty(Arraival.Text))
                {
                    MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.");
                    return;
                }
            try
            {


                // إنشاء كائن جديد للحيوان
                pet NewPet = new pet()
                {
                    petId = 0,
                    petSex = petgender.Text,
                    petBreed = BreedCombo.SelectedItem?.ToString(),
                    petSpecies = speciestxt.Text,
                    petColor = PetColor.SelectedItem?.ToString(),
                    healthStatus = health.SelectedItem?.ToString(),
                    dateOfArraival = Arraival.Text,
                    yearOfBirth = YearOfBirth.Text,
                    petState = "No",
                    petSetter = int.Parse(petsetter.Text),
                    adopter = null,
                    adoptDate = null,
                    petImage = null,

                };


                // إضافة الحيوان الجديد إلى قاعدة البيانات
                littleSouls.pets.Add(NewPet);
                littleSouls.SaveChanges();
                MessageBox.Show("تمت إضافة الحيوان بنجاح!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء إضافة الحيوان: " + ex.Message);

                if (ex.InnerException != null)
                {
                    MessageBox.Show("التفاصيل: " + ex.InnerException.Message);
                    ;
                }

                // للحصول على تفاصيل الأخطاء الخاصة بـ Entity Framework
                var entityErrors = littleSouls.GetValidationErrors();
                foreach (var entityError in entityErrors)
                {
                    foreach (var validationError in entityError.ValidationErrors)
                    {
                        MessageBox.Show($"خطأ في {entityError.Entry.Entity.GetType().Name}: {validationError.PropertyName} - {validationError.ErrorMessage}");
                    }
                }
            }
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

        private void navBarPanel1_showLogInForm(object sender, EventArgs e)
        {
            this.Hide();
            var LoginForm = new login();
            LoginForm.WindowState = FormWindowState.Minimized;
            LoginForm.FormClosed += (s, args) => this.Close();
            LoginForm.Show();
        }
    }
}
