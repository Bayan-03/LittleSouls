using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LittleSouls
{
    public partial class storageForm : Form
    {

        littleSoulsEntities littleSouls = new littleSoulsEntities();

        //private string connectionString = Settings.ConnctionString; // عدل معلومات الاتصال
        //private SqlDataAdapter dataAdapter;
        //private DataTable dataTable;
        public storageForm()
        {
            InitializeComponent();
            LoadAllData();
        }


        private void LoadAllData()
        {


            ComboBoxStorgeCategories.Items.Add("Food");
            ComboBoxStorgeCategories.Items.Add("Toys");
            ComboBoxStorgeCategories.Items.Add("Supplies");

            try
            {
                // جلب جميع البيانات من جدول الحيوانات باستخدام LINQ to Entities
                var storageView = littleSouls.storage
                    .Select(p => new
                    {
                        p.shipmentNo,
                        p.itemCode,
                        p.quantity,
                        p.price,
                        p.receivedDate,
                        p.itemCondition,
                        p.expirationDate,
                        p.supplier
                      
                    })
                    .ToList();

                // ربط البيانات بـ DataGridView
                dataGridViewStorage.DataSource =storageView;

                // جلب أنواع الحيوانات الفريدة لعرضها في ComboBox
                var StorgeCategorie = littleSouls.storage
                    .Select(p => p.supplier)
                    .Distinct()
                    .ToList();

                // إضافة خيار "الكل" كأول عنصر
                StorgeCategorie.Insert(0, "All");

                // ربط الأنواع بـ ComboBox
                ComboBoxStorgeCategories.DataSource = StorgeCategorie;

                // تعيين القيمة الافتراضية إلى "الكل"
                ComboBoxStorgeCategories.SelectedIndex = 0;
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
                string selectedCategorie = ComboBoxStorgeCategories.SelectedItem?.ToString();

                // استعلام قاعدة البيانات
                var filteredStorageQuery = littleSouls.storage.AsQueryable();

                // تطبيق الفلترة إذا لم يكن النوع "All"
                if (!string.IsNullOrEmpty(selectedCategorie) && selectedCategorie!= "All")
                {
                    filteredStorageQuery= filteredStorageQuery.Where(p => p.supplier == selectedCategorie);
                }

                // جلب البيانات المطلوبة فقط
                var filteredstorage = filteredStorageQuery
                    .Select(p => new
                    {
                        p.shipmentNo,
                        p.itemCode,
                        p.quantity,
                        p.price,
                        p.receivedDate,
                        p.itemCondition,
                        p.expirationDate,
                        p.supplier
                    })
                    .ToList();

                // عرض البيانات في DataGridView
                dataGridViewStorage.DataSource = filteredstorage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تصفية البيانات: {ex.Message}");
            }
        }


        private void storgeForm_Load(object sender, EventArgs e)
        {

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        dataAdapter = new SqlDataAdapter("SELECT * FROM storage", connection);
            //        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            //        dataTable = new DataTable();
            //        dataAdapter.Fill(dataTable);
            //        dataGridViewStorage.DataSource = dataTable;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error loading data: {ex.Message}");
            //    }
            //}
        }

        //private void SaveChanges()
        //{
        //    try
        //    {
        //        dataAdapter.Update(dataTable);
        //        MessageBox.Show("Changes saved successfully!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error saving changes: {ex.Message}");
        //    }
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    SaveChanges();
        //}

        private void ComboBoxStorgeCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            FilterPetsByType();


         
        }

        private void FilterDataByItemName(string selectedItemName)
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();

            //        // استعلام SQL مع JOIN بين جدول storage و items
            //        string query = @"
            //                       SELECT s.*
            //                       FROM storage s
            //                       INNER JOIN items i ON s.itemCode = i.itemCode
            //                       WHERE i.itemName = @selectedItemName";

            //        SqlCommand command = new SqlCommand(query, connection);
            //        command.Parameters.AddWithValue("@selectedItemName", selectedItemName);  // القيمة المختارة من ComboBox

            //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //        DataTable dataTable = new DataTable();
            //        dataAdapter.Fill(dataTable);

            //        // ربط DataGridView بالبيانات المصفاة
            //        dataGridViewStorage.DataSource = dataTable;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error loading data: {ex.Message}");
            //    }
            //}
        }



        private void LoadItemNamesIntoComboBox()
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();

            //        // استعلام لتحميل itemNames من جدول items
            //        string query = "SELECT itemName FROM items";
            //        SqlCommand command = new SqlCommand(query, connection);
            //        SqlDataReader reader = command.ExecuteReader();

            //        // ملء ComboBox بالقيم من جدول items
            //        while (reader.Read())
            //        {
            //            ComboBoxStorgeCategories.Items.Add(reader["itemName"].ToString());
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error loading item names: {ex.Message}");
            //    }
            //}
        }


        private void SaveChanges()
        {
            //try
            //{
            //    dataAdapter.Update(dataTable);
            //    MessageBox.Show("Changes saved successfully!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error saving changes: {ex.Message}");
            //}
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //SaveChanges();
        }
    }

}
