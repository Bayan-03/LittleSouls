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
    public partial class RepotrDp : Form
    {
        public RepotrDp()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void RepotrDp_Load(object sender, EventArgs e)
        {

        }

        private void Uploadfile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "اختر ملفًا",
                    Filter = "All Files (*.*)|*.*|Text Files (*.txt)|*.txt|Image Files (*.jpg;*.png)|*.jpg;*.png",
                    FilterIndex = 1,
                    Multiselect = false 
                };

                   //بس لين هنا يكفي
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             var mgrForm = new Mgr();
            mgrForm.WindowState = FormWindowState.Maximized;
            mgrForm.FormClosed += (s, args) => this.Close();
            mgrForm.Show();
        }
    }
}
