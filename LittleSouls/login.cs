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
    public partial class login : Form
    {
        //SqlConnection connect
        //    = new SqlConnection(@"Data Source=MyCumputer;Initial Catalog=littleSouls; Integrated Security=True;");


        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            // استدعاء بيانات من واجهة المستخدم
            string userName = login_username.Text.Trim();
            string password = login_password.Text.Trim();
            string jobTitle = comboBoxJobTitle.SelectedItem?.ToString();

            // التحقق من أن الحقول ليست فارغة
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(jobTitle))
            {
                MessageBox.Show("Please fill in the fields.", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // سلسلة الاتصال بقاعدة البيانات
            string connectionString = "Server=MyCumputer;Database=littleSouls;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // استعلام SQL للتحقق من البيانات
                    string query = @"SELECT jobTitle FROM employee 
                                     WHERE userName = @userName AND Pass = @password AND jobTitle = @jobTitle";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // إضافة المعاملات لمنع هجمات SQL Injection
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@jobTitle", jobTitle);

                        object result = command.ExecuteScalar();

                        // التحقق من النتيجة
                        if (result != null)
                        {
                            switch (jobTitle.ToLower())
                            {
                                case "veterinary":
                                case "pet setter":
                                case "cashier":
                                    MessageBox.Show("log in as Staff.", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Home staffForm = new Home();
                                    staffForm.Show();
                                    this.Hide();
                                    break;

                                case "treasurer":
                                case "storagekeeper":
                                    MessageBox.Show("log in as manager.", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Mgr managerForm = new Mgr();
                                    managerForm.Show();
                                    this.Hide();
                                    break;

                                

                                case "ceo":
                                    MessageBox.Show("log in as CEO.", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CEO ceoForm = new CEO();
                                    ceoForm.Show();
                                    this.Hide();
                                    break;

                                default:
                                    MessageBox.Show(" Invalid Job Title.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while connecting to the database: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

