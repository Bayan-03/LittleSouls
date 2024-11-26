namespace LittleSouls
{
    partial class Pets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pets));
            this.label1 = new System.Windows.Forms.Label();
            this.AllPetsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.AdoptBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddPetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.navBarPanel1 = new LittleSouls.NavBarPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(131, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "PETS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AllPetsbtn
            // 
            this.AllPetsbtn.Animated = true;
            this.AllPetsbtn.BackColor = System.Drawing.Color.Transparent;
            this.AllPetsbtn.BorderRadius = 20;
            this.AllPetsbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllPetsbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllPetsbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllPetsbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllPetsbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(219)))), ((int)(((byte)(157)))));
            this.AllPetsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPetsbtn.ForeColor = System.Drawing.Color.Black;
            this.AllPetsbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AllPetsbtn.Image = global::LittleSouls.Properties.Resources.dog;
            this.AllPetsbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AllPetsbtn.ImageOffset = new System.Drawing.Point(5, 30);
            this.AllPetsbtn.ImageSize = new System.Drawing.Size(124, 124);
            this.AllPetsbtn.Location = new System.Drawing.Point(279, 257);
            this.AllPetsbtn.Name = "AllPetsbtn";
            this.AllPetsbtn.Size = new System.Drawing.Size(407, 206);
            this.AllPetsbtn.TabIndex = 9;
            this.AllPetsbtn.Text = "All Pets";
            this.AllPetsbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AllPetsbtn.TextOffset = new System.Drawing.Point(0, -30);
            this.AllPetsbtn.Click += new System.EventHandler(this.AllPetsbtn_Click);
            // 
            // AdoptBtn
            // 
            this.AdoptBtn.Animated = true;
            this.AdoptBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdoptBtn.BorderRadius = 20;
            this.AdoptBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdoptBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdoptBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdoptBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdoptBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(219)))), ((int)(((byte)(157)))));
            this.AdoptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdoptBtn.ForeColor = System.Drawing.Color.Black;
            this.AdoptBtn.Image = global::LittleSouls.Properties.Resources.pet_care;
            this.AdoptBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AdoptBtn.ImageOffset = new System.Drawing.Point(5, 20);
            this.AdoptBtn.ImageSize = new System.Drawing.Size(120, 120);
            this.AdoptBtn.Location = new System.Drawing.Point(824, 257);
            this.AdoptBtn.Name = "AdoptBtn";
            this.AdoptBtn.Size = new System.Drawing.Size(407, 206);
            this.AdoptBtn.TabIndex = 10;
            this.AdoptBtn.Text = "Adoption";
            this.AdoptBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdoptBtn.TextOffset = new System.Drawing.Point(0, -30);
            this.AdoptBtn.Click += new System.EventHandler(this.AdoptBtn_Click);
            // 
            // AddPetBtn
            // 
            this.AddPetBtn.Animated = true;
            this.AddPetBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddPetBtn.BorderRadius = 20;
            this.AddPetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddPetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddPetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddPetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddPetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(219)))), ((int)(((byte)(157)))));
            this.AddPetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPetBtn.ForeColor = System.Drawing.Color.Black;
            this.AddPetBtn.Image = global::LittleSouls.Properties.Resources.adoption;
            this.AddPetBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddPetBtn.ImageOffset = new System.Drawing.Point(5, 20);
            this.AddPetBtn.ImageSize = new System.Drawing.Size(115, 115);
            this.AddPetBtn.Location = new System.Drawing.Point(551, 521);
            this.AddPetBtn.Name = "AddPetBtn";
            this.AddPetBtn.Size = new System.Drawing.Size(407, 206);
            this.AddPetBtn.TabIndex = 11;
            this.AddPetBtn.Text = "Add  Pet";
            this.AddPetBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddPetBtn.TextOffset = new System.Drawing.Point(0, -30);
            this.AddPetBtn.Click += new System.EventHandler(this.AddPetBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(68, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1367, 45);
            this.guna2Panel1.TabIndex = 13;
            // 
            // navBarPanel1
            // 
            this.navBarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel1.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.navBarPanel1.Name = "navBarPanel1";
            this.navBarPanel1.Size = new System.Drawing.Size(68, 830);
            this.navBarPanel1.TabIndex = 14;
            this.navBarPanel1.showHomeForm += new System.EventHandler(this.navBarPanel1_showHomeForm);
            this.navBarPanel1.showPetsForm += new System.EventHandler(this.navBarPanel1_showPetsForm);
            this.navBarPanel1.showMedicalCareForm += new System.EventHandler(this.navBarPanel1_showMedicalCareForm);
            this.navBarPanel1.showInvoiceForm += new System.EventHandler(this.navBarPanel1_showInvoiceForm);
            this.navBarPanel1.showLogInForm += new System.EventHandler(this.navBarPanel1_showLogInForm);
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPetBtn);
            this.Controls.Add(this.AdoptBtn);
            this.Controls.Add(this.AllPetsbtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.navBarPanel1);
            this.Name = "Pets";
            this.Text = "Pets";
            this.Load += new System.EventHandler(this.Pets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AllPetsbtn;
        private Guna.UI2.WinForms.Guna2Button AdoptBtn;
        private Guna.UI2.WinForms.Guna2Button AddPetBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private NavBarPanel navBarPanel1;
    }
}