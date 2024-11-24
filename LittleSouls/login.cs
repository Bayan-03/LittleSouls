using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using System.Data;
>>>>>>> Stashed changes
using System.Data.SqlClient;

namespace LittleSouls
{
    public partial class login : Form
    {
<<<<<<< Updated upstream
        //SqlConnection connect
        //    = new SqlConnection(@"Data Source=MyCumputer;Initial Catalog=littleSouls; Integrated Security=True;");


=======
        SqlConnection connect
            = new SqlConnection(@"Data Source=MyCumputer;Initial Catalog=littleSouls; Integrated Security=True;");
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream

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
            string connectionString = Settings.ConnctionString;

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
                                    this.Hide();
                                    var staffForm = new Home();
                                    staffForm.WindowState = FormWindowState.Maximized;
                                    staffForm.FormClosed += (s, args) => this.Close();
                                    staffForm.Show();
                                    staffForm.Show();
                                    break;

                                case "treasurer":
                                case "storagekeeper":
                                    MessageBox.Show("log in as manager.", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();

                                    var managerForm = new Mgr();
                                    managerForm.WindowState = FormWindowState.Maximized;
                                    managerForm.FormClosed += (s, args) => this.Close();
                                    managerForm.Show();
                                    managerForm.Show();
                                    break;

                                

                                case "ceo":
                                    MessageBox.Show("log in as CEO.", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();

                                    var ceoForm = new CEO();
                                    ceoForm.WindowState = FormWindowState.Maximized;
                                    ceoForm.FormClosed += (s, args) => this.Close();
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

        private void comboBoxJobTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
=======
            if (login_username.Text == ""
                || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username " +
                            "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //MainForm mForm = new MainForm();
                                //mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

>>>>>>> Stashed changes
        }
    }
}

