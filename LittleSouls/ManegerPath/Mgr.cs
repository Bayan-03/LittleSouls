﻿using System;
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
    public partial class Mgr : Form
    {
        public Mgr()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var stForm = new storageForm();
            stForm.WindowState = FormWindowState.Maximized;
            stForm.FormClosed += (s, args) => this.Close();
            stForm.Show();


        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Tb_panal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameLable_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mgr_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var EmployeesDpForm = new EmployeesDp();
            EmployeesDpForm.WindowState = FormWindowState.Maximized;
            EmployeesDpForm.FormClosed += (s, args) => this.Close();
            EmployeesDpForm.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //this.Hide();

            //var CotractsDpForm = new CotractsDp();
            //CotractsDpForm.WindowState = FormWindowState.Maximized;
            //CotractsDpForm.FormClosed += (s, args) => this.Close();
            //CotractsDpForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var reportForm = new RepotrDp();
            reportForm.WindowState = FormWindowState.Maximized;
            reportForm.FormClosed += (s, args) => this.Close();
            reportForm.Show();
        }

        //private void guna2Button4_Click(object sender, EventArgs e)
        //{

        //}
    }
}