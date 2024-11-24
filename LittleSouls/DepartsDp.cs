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
        public DepartsDp()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {

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
