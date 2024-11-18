namespace LittleSouls
{
    partial class DonatsDp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonatsDp));
            this.Tb_panal = new Guna.UI2.WinForms.Guna2Panel();
            this.SopjectLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Tb_panal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_panal
            // 
            this.Tb_panal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.Tb_panal.Controls.Add(this.SopjectLable);
            this.Tb_panal.Location = new System.Drawing.Point(-1, -1);
            this.Tb_panal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_panal.Name = "Tb_panal";
            this.Tb_panal.Size = new System.Drawing.Size(1440, 82);
            this.Tb_panal.TabIndex = 38;
            // 
            // SopjectLable
            // 
            this.SopjectLable.AutoSize = false;
            this.SopjectLable.BackColor = System.Drawing.Color.Transparent;
            this.SopjectLable.Font = new System.Drawing.Font("Graphik Arabic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SopjectLable.ForeColor = System.Drawing.Color.Black;
            this.SopjectLable.Location = new System.Drawing.Point(82, 29);
            this.SopjectLable.Name = "SopjectLable";
            this.SopjectLable.Size = new System.Drawing.Size(196, 32);
            this.SopjectLable.TabIndex = 5;
            this.SopjectLable.Text = "Donations";
            this.SopjectLable.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(182, 135);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1073, 677);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 40;
            this.guna2PictureBox1.TabStop = false;
            // 
            // DonatsDp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.ClientSize = new System.Drawing.Size(1437, 838);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Tb_panal);
            this.Name = "DonatsDp";
            this.Text = "Donations";
            this.Tb_panal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Tb_panal;
        private Guna.UI2.WinForms.Guna2HtmlLabel SopjectLable;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}