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
    public partial class EmployeesDp : Form
    {
        littleSoulsEntities littleSouls = new littleSoulsEntities();

        public EmployeesDp()
        {
            InitializeComponent();
            LoadAllData();

        }
        private void LoadAllData()
        {
            try
            {
                // جلب جميع البيانات من جدول الحيوانات باستخدام LINQ to Entities
                var Empol = littleSouls.employees
                    .Select(p => new
                    {
                        p.firstName,
                        p.lastName,
                        p.yearOfBirth,
                        p.userName,
                        p.email,
                        p.Pass,
                        p.jobTitle,
                        p.phoneNumber,
                        p.salary,
                        p.employeeStatus,
                        p.employeeId,
                        p.employeeManager,
                        p.departmentId
                    })
                    .ToList();

                // ربط البيانات بـ DataGridView
                AllEmployTable.DataSource= Empol;

                // جلب أنواع الحيوانات الفريدة لعرضها في ComboBox
                 var EmpolTypes = littleSouls.employees
                    .Select(p => p.jobTitle)
                    .Distinct()
                    .ToList();

                // إضافة خيار "الكل" كأول عنصر
                EmpolTypes.Insert(0, "All");

                // ربط الأنواع بـ ComboBox
                emploeeType.DataSource = EmpolTypes;

                // تعيين القيمة الافتراضية إلى "الكل"
                emploeeType.SelectedIndex = 0;
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
                string selectedType = emploeeType.SelectedItem.ToString();

                // استعلام قاعدة البيانات
                var filteredPetsQuery = littleSouls.employees.AsQueryable();

                // تطبيق الفلترة إذا لم يكن النوع "All"
                if (!string.IsNullOrEmpty(selectedType) && selectedType != "All")
                {
                    filteredPetsQuery = filteredPetsQuery.Where(p => p.jobTitle == selectedType);
                }

                // جلب البيانات المطلوبة فقط
                var filteredPets = filteredPetsQuery
                    .Select(p => new
                    {
                        p.firstName,
                        p.lastName,
                        p.yearOfBirth,
                        p.userName,
                        p.email,
                        p.Pass,
                        p.jobTitle,
                        p.phoneNumber,
                        p.salary,
                        p.employeeStatus,
                        p.employeeId,
                        p.employeeManager,
                        p.departmentId
                    })
                    .ToList();

                // عرض البيانات في DataGridView
                AllEmployTable.DataSource = filteredPets;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصفية البيانات: {ex.Message}");
            }
        }

        private void SopjectLable_Click(object sender, EventArgs e)
        {

        }

        private void EmployeesDp_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var EmployeesButton = new Mgr();
            EmployeesButton.WindowState = FormWindowState.Maximized;
            EmployeesButton.FormClosed += (s, args) => this.Close();
            EmployeesButton.Show();
        }
    }
}
