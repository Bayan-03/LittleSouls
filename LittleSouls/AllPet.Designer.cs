namespace LittleSouls
{
    partial class AllPet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.petType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllpetTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Pet_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yearofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petspecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petbreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petarraival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Helthstate = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.adoptionstatu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.petseter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adopter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SideBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllpetTable)).BeginInit();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // petType
            // 
            this.petType.AllowDrop = true;
            this.petType.AutoRoundedCorners = true;
            this.petType.BackColor = System.Drawing.Color.Transparent;
            this.petType.BorderColor = System.Drawing.Color.Black;
            this.petType.BorderRadius = 17;
            this.petType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.petType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petType.Font = new System.Drawing.Font("Graphik Arabic", 10.2F);
            this.petType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.petType.ItemHeight = 30;
            this.petType.Items.AddRange(new object[] {
            "Cats",
            "Dogs",
            "Fish",
            "Birds",
            "Chicks",
            "Ducks",
            "Turtle"});
            this.petType.Location = new System.Drawing.Point(1102, 142);
            this.petType.Name = "petType";
            this.petType.Size = new System.Drawing.Size(291, 36);
            this.petType.TabIndex = 32;
            this.petType.SelectedIndexChanged += new System.EventHandler(this.petType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(938, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "Categories";
            // 
            // AllpetTable
            // 
            this.AllpetTable.AllowUserToAddRows = false;
            this.AllpetTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.AllpetTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllpetTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AllpetTable.ColumnHeadersHeight = 36;
            this.AllpetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllpetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pet_ID,
            this.petname,
            this.Yearofbirth,
            this.petGender,
            this.petspecies,
            this.petbreed,
            this.petarraival,
            this.petcolor,
            this.Helthstate,
            this.adoptionstatu,
            this.petseter,
            this.Adopter,
            this.petimage});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllpetTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.AllpetTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllpetTable.Location = new System.Drawing.Point(103, 224);
            this.AllpetTable.Name = "AllpetTable";
            this.AllpetTable.ReadOnly = true;
            this.AllpetTable.RowHeadersVisible = false;
            this.AllpetTable.RowHeadersWidth = 51;
            this.AllpetTable.RowTemplate.Height = 26;
            this.AllpetTable.Size = new System.Drawing.Size(1302, 583);
            this.AllpetTable.TabIndex = 36;
            this.AllpetTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AllpetTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AllpetTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AllpetTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AllpetTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AllpetTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AllpetTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllpetTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AllpetTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllpetTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AllpetTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AllpetTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllpetTable.ThemeStyle.HeaderStyle.Height = 36;
            this.AllpetTable.ThemeStyle.ReadOnly = true;
            this.AllpetTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AllpetTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllpetTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AllpetTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllpetTable.ThemeStyle.RowsStyle.Height = 26;
            this.AllpetTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllpetTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllpetTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // Pet_ID
            // 
            this.Pet_ID.HeaderText = "ID";
            this.Pet_ID.MinimumWidth = 6;
            this.Pet_ID.Name = "Pet_ID";
            this.Pet_ID.ReadOnly = true;
            // 
            // petname
            // 
            this.petname.HeaderText = "Name";
            this.petname.MinimumWidth = 6;
            this.petname.Name = "petname";
            this.petname.ReadOnly = true;
            // 
            // Yearofbirth
            // 
            this.Yearofbirth.HeaderText = "Birth Date";
            this.Yearofbirth.MinimumWidth = 6;
            this.Yearofbirth.Name = "Yearofbirth";
            this.Yearofbirth.ReadOnly = true;
            // 
            // petGender
            // 
            this.petGender.HeaderText = "Gender";
            this.petGender.MinimumWidth = 6;
            this.petGender.Name = "petGender";
            this.petGender.ReadOnly = true;
            // 
            // petspecies
            // 
            this.petspecies.HeaderText = "Species";
            this.petspecies.MinimumWidth = 6;
            this.petspecies.Name = "petspecies";
            this.petspecies.ReadOnly = true;
            // 
            // petbreed
            // 
            this.petbreed.HeaderText = "Breed";
            this.petbreed.MinimumWidth = 6;
            this.petbreed.Name = "petbreed";
            this.petbreed.ReadOnly = true;
            // 
            // petarraival
            // 
            this.petarraival.HeaderText = "Arraival Date";
            this.petarraival.MinimumWidth = 6;
            this.petarraival.Name = "petarraival";
            this.petarraival.ReadOnly = true;
            // 
            // petcolor
            // 
            this.petcolor.HeaderText = "Color";
            this.petcolor.MinimumWidth = 6;
            this.petcolor.Name = "petcolor";
            this.petcolor.ReadOnly = true;
            // 
            // Helthstate
            // 
            this.Helthstate.HeaderText = "health Satute";
            this.Helthstate.MinimumWidth = 6;
            this.Helthstate.Name = "Helthstate";
            this.Helthstate.ReadOnly = true;
            // 
            // adoptionstatu
            // 
            this.adoptionstatu.HeaderText = "Adoption State";
            this.adoptionstatu.MinimumWidth = 6;
            this.adoptionstatu.Name = "adoptionstatu";
            this.adoptionstatu.ReadOnly = true;
            // 
            // petseter
            // 
            this.petseter.HeaderText = "Pet Setter";
            this.petseter.MinimumWidth = 6;
            this.petseter.Name = "petseter";
            this.petseter.ReadOnly = true;
            // 
            // Adopter
            // 
            this.Adopter.HeaderText = "Adopter";
            this.Adopter.MinimumWidth = 6;
            this.Adopter.Name = "Adopter";
            this.Adopter.ReadOnly = true;
            // 
            // petimage
            // 
            this.petimage.HeaderText = "photo";
            this.petimage.MinimumWidth = 6;
            this.petimage.Name = "petimage";
            this.petimage.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(69, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1366, 45);
            this.guna2Panel1.TabIndex = 37;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.SideBar.Controls.Add(this.guna2Button5);
            this.SideBar.Controls.Add(this.guna2Button4);
            this.SideBar.Controls.Add(this.guna2Button3);
            this.SideBar.Controls.Add(this.guna2Button2);
            this.SideBar.Controls.Add(this.guna2Button1);
            this.SideBar.Controls.Add(this.guna2CirclePictureBox1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(69, 830);
            this.SideBar.TabIndex = 38;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::LittleSouls.Properties.Resources.paws;
            this.guna2Button5.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button5.Location = new System.Drawing.Point(0, 206);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(69, 61);
            this.guna2Button5.TabIndex = 24;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::LittleSouls.Properties.Resources.animal_care;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(0, 257);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(69, 61);
            this.guna2Button4.TabIndex = 23;
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::LittleSouls.Properties.Resources.invoice;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(0, 308);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(69, 61);
            this.guna2Button3.TabIndex = 22;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::LittleSouls.Properties.Resources.setting__1_;
            this.guna2Button2.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2Button2.Location = new System.Drawing.Point(0, 734);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(69, 61);
            this.guna2Button2.TabIndex = 21;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::LittleSouls.Properties.Resources.home;
            this.guna2Button1.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2Button1.Location = new System.Drawing.Point(0, 142);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(69, 61);
            this.guna2Button1.TabIndex = 20;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::LittleSouls.Properties.Resources.icon_logo_061;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(54, 54);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Graphik Arabic Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(130, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 39;
            this.label1.Text = "All Souls";
            // 
            // AllPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.AllpetTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petType);
            this.Name = "AllPet";
            this.Text = "AllPet";
            ((System.ComponentModel.ISupportInitialize)(this.AllpetTable)).EndInit();
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox petType;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView AllpetTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pet_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn petname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yearofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn petGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn petspecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn petbreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn petarraival;
        private System.Windows.Forms.DataGridViewTextBoxColumn petcolor;
        private System.Windows.Forms.DataGridViewComboBoxColumn Helthstate;
        private System.Windows.Forms.DataGridViewComboBoxColumn adoptionstatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn petseter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adopter;
        private System.Windows.Forms.DataGridViewImageColumn petimage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel SideBar;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
    }
}