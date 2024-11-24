namespace LittleSouls
{
    partial class RepotrDp
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
            this.Tb_panal = new Guna.UI2.WinForms.Guna2Panel();
            this.SopjectLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Tb_panal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tb_panal
            // 
            this.Tb_panal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.Tb_panal.Controls.Add(this.guna2Button1);
            this.Tb_panal.Controls.Add(this.SopjectLable);
            this.Tb_panal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tb_panal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.Tb_panal.Location = new System.Drawing.Point(0, 0);
            this.Tb_panal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tb_panal.Name = "Tb_panal";
            this.Tb_panal.Size = new System.Drawing.Size(1437, 82);
            this.Tb_panal.TabIndex = 38;
            // 
            // SopjectLable
            // 
            this.SopjectLable.AutoSize = false;
            this.SopjectLable.BackColor = System.Drawing.Color.Transparent;
            this.SopjectLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SopjectLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.SopjectLable.Location = new System.Drawing.Point(80, 29);
            this.SopjectLable.Name = "SopjectLable";
            this.SopjectLable.Size = new System.Drawing.Size(177, 32);
            this.SopjectLable.TabIndex = 5;
            this.SopjectLable.Text = "Reports";
            this.SopjectLable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Graphik Arabic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.guna2Button1.Location = new System.Drawing.Point(1243, 19);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(126, 45);
            this.guna2Button1.TabIndex = 39;
            this.guna2Button1.Text = "Go Back";
            // 
            // RepotrDp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.ClientSize = new System.Drawing.Size(1437, 838);
            this.Controls.Add(this.Tb_panal);
            this.Name = "RepotrDp";
            this.Text = "Reportscs";
            this.Load += new System.EventHandler(this.RepotrDp_Load);
            this.Tb_panal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Tb_panal;
        private Guna.UI2.WinForms.Guna2HtmlLabel SopjectLable;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}