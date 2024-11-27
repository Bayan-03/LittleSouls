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
    public partial class DepartsDp : Form
    {
        littleSoulsEntities littleSouls = new littleSoulsEntities();

        public DepartsDp()
        {
            InitializeComponent();
            LoadAllData();
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }
        private void LoadAllData()
        {
            try
            {
                // جلب جميع البيانات من جدول الحيوانات باستخدام LINQ to Entities
                var Empol = littleSouls.departments
                    .Select(p => new
                    {
                        p.departmentId,
                        p.departmentName
                       
                    })
                    .ToList();

                // ربط البيانات بـ DataGridView
                AlldepartTable.DataSource = Empol;

                // جلب أنواع الحيوانات الفريدة لعرضها في ComboBox
                var EmpolTypes = littleSouls.departments
                   .Select(p => p.departmentName)
                   .Distinct()
                   .ToList();

                // إضافة خيار "الكل" كأول عنصر
                EmpolTypes.Insert(0, "All");

                // ربط الأنواع بـ ComboBox
                DepartCombo.DataSource = EmpolTypes;

                // تعيين القيمة الافتراضية إلى "الكل"
                DepartCombo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات: {ex.Message}");
            }
        }
        private void FilterPetsByType()
        {
            try
            {
                // جلب النوع المحدد من ComboBox
                string selectedType = DepartCombo.SelectedItem.ToString();

                // استعلام قاعدة البيانات
                var filteredPetsQuery = littleSouls.departments.AsQueryable();

                // تطبيق الفلترة إذا لم يكن النوع "All"
                if (!string.IsNullOrEmpty(selectedType) && selectedType != "All")
                {
                    filteredPetsQuery = filteredPetsQuery.Where(p => p.departmentName == selectedType);
                }

                // جلب البيانات المطلوبة فقط
                var filteredPets = filteredPetsQuery
                    .Select(p => new
                    {
                        p.departmentId,
                        p.departmentName


                    })
                    .ToList();

                // عرض البيانات في DataGridView
                AlldepartTable.DataSource = filteredPets;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصفية البيانات: {ex.Message}");
            }
        }
        private void EmployTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var DepatsButton = new CEO();
            DepatsButton.WindowState = FormWindowState.Maximized;
            DepatsButton.FormClosed += (s, args) => this.Close();
            DepatsButton.Show();
        }
    }
}
