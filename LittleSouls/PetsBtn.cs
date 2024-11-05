using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSouls
{
    public partial class PetsBtn : Button
    {
        private Image NormalImage;
        private Image HoverImage;
        private Color HoverForecolor;
        private Color NormalForecolor;

       

        public PetsBtn()
        {
            InitializeComponent();
        }

        public Image NormalImage1 { get => NormalImage; set => NormalImage = value; }
        public Image HoverImage1 { get => HoverImage; set => HoverImage = value; }
        public Color HoverForecolor1 { get => HoverForecolor; set => HoverForecolor = value; }
        public Color NormalForecolor1 { get => NormalForecolor; set => NormalForecolor = value; }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int lr,
               int tr,
               int rr,
               int br,
               int we,
               int he
           );

        private void PetsBtn_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = HoverForecolor;
            Image = HoverImage;
        }

        private void PetsBtn_MouseLeave(object sender, EventArgs e)
        {
            Image = NormalImage1;
            ForeColor = NormalForecolor1;
        }

        private void PetsBtn_Paint(object sender, PaintEventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
    }
}
