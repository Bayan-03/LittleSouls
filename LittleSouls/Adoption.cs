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
            // TODO: This line of code loads data into the 'littleSoulsDataSet1.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.littleSoulsDataSet1.pet);
            // TODO: This line of code loads data into the 'littleSoulsDataSet.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.littleSoulsDataSet.pet);

        }
        int indexrow;
        private void Adoptbtn_Click(object sender, EventArgs e)
        {
                int selectedRowIndex = -1;
                try
                {
                    // التحقق من اختيار صف صالح
                    if (selectedRowIndex >= 0)
                    {
                        // الحصول على PetID من الصف المحدد في DataGridView
                        int petID = int.Parse(adopttable.Rows[selectedRowIndex].Cells["PetID"].Value.ToString());

                        // العثور على السجل المطابق في قاعدة البيانات
                        pet selectedPet = littleSouls2.pet.FirstOrDefault(p => p.petId == petID);

                        if (selectedPet != null)
                        {
                            // تحديث OwnerID فقط من TextBox
                            if (int.TryParse(OwnerIDTextBox.Text, out int ownerID))
                            {
                                selectedPet.adopter = ownerID;
                                selectedPet.adoptDate = DateTime.Now.ToString("dd-MM-yyyy"); // تاريخ ووقت التحديث الحالي فقط

                                // حفظ التغييرات في قاعدة البيانات
                                littleSouls2.SaveChanges();

                                MessageBox.Show("تم تحديث OwnerID و AdoptionDate بنجاح!");

                                // تحديث البيانات في DataGridView
                                this.petTableAdapter.Fill(this.littleSoulsDataSet1.pet);
                            }
                            else
                            {
                                MessageBox.Show("يرجى إدخال قيمة رقمية صحيحة لـ OwnerID.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على السجل المحدد.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى اختيار صف من الجدول أولاً.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء التحديث: " + ex.Message);
                }
            


        }



      
    }
}
