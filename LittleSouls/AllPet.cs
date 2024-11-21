using LittleSouls.littleSoulsDataSetTableAdapters;
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
    public partial class AllPet : Form
    {
        public AllPet()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void petType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllPet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'littleSoulsDataSet.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.littleSoulsDataSet.pet);
            petType.SelectedIndex = 0;

        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }
    }
}
