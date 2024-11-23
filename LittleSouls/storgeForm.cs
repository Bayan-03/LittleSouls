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



        private string connectionString = "Server=MyCumputer;Database=littleSouls;Trusted_Connection=True;"; // عدل معلومات الاتصال
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public storageForm()
        {
            InitializeComponent();
        }

        private void storgeForm_Load(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter("SELECT * FROM storage", connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewStorage.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
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
            //string selectedCategory = ComboBoxStorgeCategories.SelectedItem.ToString();
            //FilterData(selectedCategory);
            // الحصول على قيمة itemName التي اختارها المستخدم من ComboBox
            string selectedItemName = ComboBoxStorgeCategories.SelectedItem.ToString();

            // تصفية البيانات بناءً على itemName
            FilterDataByItemName(selectedItemName);
        }

        private void FilterDataByItemName(string selectedItemName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // استعلام SQL مع JOIN بين جدول storage و items
                    string query = @"
                                   SELECT s.*
                                   FROM storage s
                                   INNER JOIN items i ON s.itemCode = i.itemCode
                                   WHERE i.itemName = @selectedItemName";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedItemName", selectedItemName);  // القيمة المختارة من ComboBox

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // ربط DataGridView بالبيانات المصفاة
                    dataGridViewStorage.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }



        private void LoadItemNamesIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // استعلام لتحميل itemNames من جدول items
                    string query = "SELECT itemName FROM items";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // ملء ComboBox بالقيم من جدول items
                    while (reader.Read())
                    {
                        ComboBoxStorgeCategories.Items.Add(reader["itemName"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading item names: {ex.Message}");
                }
            }
        }


        private void SaveChanges()
        {
            try
            {
                dataAdapter.Update(dataTable);
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }

}
