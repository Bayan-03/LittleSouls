using LittleSouls;
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
    public partial class PetsExamination : Form
    {
        littleSoulsEntities littleSouls = new littleSoulsEntities();
        public PetsExamination()
        {
            InitializeComponent();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void petspecies_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PetsExamination_Load(object sender, EventArgs e)
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

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(treatment.Text) ||
                   string.IsNullOrEmpty(diagnos.Text) ||
                   string.IsNullOrEmpty(petid.Text) ||
                   string.IsNullOrEmpty(vaccinations.Text) ||
                   string.IsNullOrEmpty(vaccinations.Text) ||
                   string.IsNullOrEmpty(surgeryinfo.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.");
                return;
            }
            try
            {

                medicalRecod mr = new medicalRecod()
                {
                    petId = int.Parse(petid.Text),
                    dateOfExamination = DateTime.Now.ToString("dd-MM-yyyy"),
                    treatmentsProvided = treatment.Text,
                    diagnosis = diagnos.SelectedItem.ToString(),
                    surgeryInformation = surgeryinfo.Text,
                    vaccinations = vaccinations.Text,
                    vetetinarianId = int.Parse(veteinarianId.Text)
                };
                littleSouls.medicalRecod.Add(mr);
                littleSouls.SaveChanges();
                MessageBox.Show(".تمت إضافة السجل الطبي بنجاح!");

                diagnos.SelectedIndex = -1;
                treatment.Clear();
                surgeryinfo.Clear();
                vaccinations.Clear();
                petid.Clear();
                veteinarianId.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show("حدث خطأ أثناء إضافة السجل الطبي: " + ex.Message);

                if (ex.InnerException != null)
                {
                    MessageBox.Show("التفاصيل: " + ex.InnerException.Message);
                    ;
                }

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

    }
}


