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
    public partial class NavBarPanel : UserControl
    {
        public NavBarPanel()
        {
            InitializeComponent();
        }
        public event EventHandler showHomeForm;
        public event EventHandler showPetsForm;
        public event EventHandler showMedicalCareForm;
        public event EventHandler showInvoiceForm;
        public event EventHandler showLogInForm;


        private void onShowedHomeForm()
        {
            var handler = this.showHomeForm;
            if (handler != null)
            {
               handler(this, EventArgs.Empty);
            }
        }
        private void onshowPetsForm()
        {
            var handler = this.showPetsForm;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        private void onshowMedicalCareForm()
        {
            var handler = this.showMedicalCareForm;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        private void onshowInvoiceForm()
        {
            var handler = this.showInvoiceForm;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        private void onshowLogInForm()
        {
            var handler = this.showLogInForm;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (showHomeForm != null)
            {
                onShowedHomeForm();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (showHomeForm != null)
            {
                onshowPetsForm();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (showHomeForm != null)
            {
                onshowMedicalCareForm();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (showHomeForm != null)
            {
                onshowInvoiceForm();
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (showHomeForm != null)
            {
                onshowLogInForm();
            }
        }



        private void SideBar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        
    }
}
