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
        public EmployeesDp()
        {
            InitializeComponent();
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
