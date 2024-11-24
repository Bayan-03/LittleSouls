using LittleSouls.littleSoulsDataSetTableAdapters;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LittleSouls
{
    public partial class AllPet : Form
    {
        littleSoulsEntities littleSouls = new littleSoulsEntities();

        public AllPet()
        {
            InitializeComponent();

            //this.petTableAdapter.Fill(this.littleSoulsDataSet.pet);
            LoadAllData();

        }

        // دالة لتحميل كل البيانات من جدول الحيوانات وربطها بـ DataGridView و ComboBox
        ////private void LoadAllData()
        ////{
        ////    // جلب جميع البيانات من جدول الحيوانات
        ////    var allPets = from p in littleSouls.pet
        ////                  select new
        ////                  {
        ////                      p.petId,
        ////                      p.dateOfArraival,
        ////                      p.yearOfBirth,
        ////                      p.petColor,
        ////                      p.petSetter,
        ////                      p.petSex,
        ////                      p.petState,
        ////                      p.petSpecies,
        ////                      p.healthStatus,
        ////                      p.petImage,
        ////                      p.adopter,
        ////                      p.adoptDate,
        ////                      p.petBreed
        ////                  };
        ////    // التصنيف يجي من الداتابيس ********************************//
        ////    petType.SelectedIndex = 0; // تحديد العنصر الافتراضي

        ////    // ربط البيانات بـ DataGridView
        ////    AllpetTable.DataSource = allPets.ToList();

        ////    // جلب أنواع الحيوانات الفريدة لعرضها في ComboBox
        ////    var petTypes = allPets.Select(p => p.petBreed).Distinct().ToList();
        ////    petTypes.Insert(0, "All"); // إضافة خيار "الكل" كأول عنصر
        ////    petType.DataSource = petTypes;
        ////    petType.SelectedIndex = 0; // تعيين القيمة الافتراضية إلى "الكل"
        ////}
        /// <summary>
        /// 
        /// </summary>
        private void LoadAllData()
        {
            try
            {
                // جلب جميع البيانات من جدول الحيوانات باستخدام LINQ to Entities
                var allPets = littleSouls.pet
                    .Select(p => new
                    {
                        p.petId,
                        p.dateOfArraival,
                        p.yearOfBirth,
                        p.petColor,
                        p.petSetter,
                        p.petSex,
                        p.petState,
                        p.petSpecies,
                        p.healthStatus,
                        p.petImage,
                        p.adopter,
                        p.adoptDate,
                        p.petBreed
                    })
                    .ToList();

                // ربط البيانات بـ DataGridView
                AllpetTable.DataSource = allPets;

                // جلب أنواع الحيوانات الفريدة لعرضها في ComboBox
                var petTypes = littleSouls.pet
                    .Select(p => p.petBreed)
                    .Distinct()
                    .ToList();

                // إضافة خيار "الكل" كأول عنصر
                petTypes.Insert(0, "All");

                // ربط الأنواع بـ ComboBox
                petType.DataSource = petTypes;

                // تعيين القيمة الافتراضية إلى "الكل"
                petType.SelectedIndex = 0;
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
                string selectedType = petType.SelectedItem?.ToString();

                // استعلام قاعدة البيانات
                var filteredPetsQuery = littleSouls.pet.AsQueryable();

                // تطبيق الفلترة إذا لم يكن النوع "All"
                if (!string.IsNullOrEmpty(selectedType) && selectedType != "All")
                {
                    filteredPetsQuery = filteredPetsQuery.Where(p => p.petBreed == selectedType);
                }

                // جلب البيانات المطلوبة فقط
                var filteredPets = filteredPetsQuery
                    .Select(p => new
                    {
                        p.petId,
                        p.dateOfArraival,
                        p.yearOfBirth,
                        p.petColor,
                        p.petSetter,
                        p.petSex,
                        p.petState,
                        p.petSpecies,
                        p.healthStatus,
                        p.petImage,
                        p.adopter,
                        p.adoptDate,
                        p.petBreed
                    })
                    .ToList();

                // عرض البيانات في DataGridView
                AllpetTable.DataSource = filteredPets;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصفية البيانات: {ex.Message}");
            }
        }

        // دالة لفلترة الحيوانات بناءً على النوع المحدد
        //////private void FilterPetsByType()
        //////{
        //////    string selectedType = petType.SelectedItem?.ToString();

        //////    if (string.IsNullOrEmpty(selectedType) || selectedType == "All")
        //////    {
        //////        // إذا كانت القيمة المختارة هي "الكل" أو فارغة، عرض كل البيانات
        //////        LoadAllData();
        //////    }
        //////    else
        //////    {
        //////        // فلترة البيانات بناءً على النوع المحدد
        //////        var filteredPets = from p in littleSouls.pet
        //////                           where p.petBreed == selectedType
        //////                           select new
        //////                           {
        //////                               p.petId,
        //////                               p.dateOfArraival,
        //////                               p.yearOfBirth,
        //////                               p.petColor,
        //////                               p.petSetter,
        //////                               p.petSex,
        //////                               p.petState,
        //////                               p.petSpecies,
        //////                               p.healthStatus,
        //////                               p.petImage,
        //////                               p.adopter,
        //////                               p.adoptDate,
        //////                               p.petBreed
        //////                           };

        //////        // عرض البيانات المفلترة في DataGridView
        //////        AllpetTable.DataSource = filteredPets.ToList();
        //////    }
        //////}

        // حدث عند تغيير اختيار النوع في ComboBox
        private void petType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterPetsByType();
        }

        // الأحداث الفارغة (محفوظة حسب الطلب)
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void AllPet_Load(object sender, EventArgs e)
        {
        }

        private void Adoption_Load(object sender, EventArgs e)
        {
            
        }

        private void AllpetTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
