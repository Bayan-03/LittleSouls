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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Petsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var PetForm = new Pets();
            PetForm.WindowState = FormWindowState.Maximized;
            PetForm.FormClosed += (s, args) => this.Close();
            PetForm.Show();
        }

        private void Invoicesbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
