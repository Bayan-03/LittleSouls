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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.petType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Home = new Guna.UI2.WinForms.Guna2Button();
            this.invoicbtn = new Guna.UI2.WinForms.Guna2Button();
            this.petHomebtn = new Guna.UI2.WinForms.Guna2Button();
            this.medbtn = new Guna.UI2.WinForms.Guna2Button();
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
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllpetTable)).BeginInit();
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
            this.petType.Location = new System.Drawing.Point(1098, 76);
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
            this.label2.Location = new System.Drawing.Point(934, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 33;
            this.label2.Text = "Categories";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.guna2Panel2.Location = new System.Drawing.Point(269, -3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1167, 52);
            this.guna2Panel2.TabIndex = 35;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.Home);
            this.guna2Panel1.Controls.Add(this.invoicbtn);
            this.guna2Panel1.Controls.Add(this.petHomebtn);
            this.guna2Panel1.Controls.Add(this.medbtn);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(275, 833);
            this.guna2Panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Graphik Arabic Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "Little Souls";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::LittleSouls.Properties.Resources.icon_logo_061;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 17);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(62, 58);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 28;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.Animated = true;
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Home.FillColor = System.Drawing.Color.Transparent;
            this.Home.Font = new System.Drawing.Font("Graphik Arabic Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.Black;
            this.Home.Image = global::LittleSouls.Properties.Resources.home;
            this.Home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Home.Location = new System.Drawing.Point(0, 126);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(275, 45);
            this.Home.TabIndex = 22;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // invoicbtn
            // 
            this.invoicbtn.Animated = true;
            this.invoicbtn.BackColor = System.Drawing.Color.Transparent;
            this.invoicbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.invoicbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invoicbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invoicbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invoicbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invoicbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invoicbtn.FillColor = System.Drawing.Color.Transparent;
            this.invoicbtn.Font = new System.Drawing.Font("Graphik Arabic Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicbtn.ForeColor = System.Drawing.Color.Black;
            this.invoicbtn.Location = new System.Drawing.Point(-3, 305);
            this.invoicbtn.Name = "invoicbtn";
            this.invoicbtn.Size = new System.Drawing.Size(275, 45);
            this.invoicbtn.TabIndex = 25;
            this.invoicbtn.Text = "Invoices";
            this.invoicbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // petHomebtn
            // 
            this.petHomebtn.Animated = true;
            this.petHomebtn.BackColor = System.Drawing.Color.Transparent;
            this.petHomebtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.petHomebtn.Checked = true;
            this.petHomebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.petHomebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.petHomebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.petHomebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.petHomebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.petHomebtn.FillColor = System.Drawing.Color.Transparent;
            this.petHomebtn.Font = new System.Drawing.Font("Graphik Arabic Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petHomebtn.ForeColor = System.Drawing.Color.Black;
            this.petHomebtn.Image = global::LittleSouls.Properties.Resources.paws;
            this.petHomebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.petHomebtn.ImageSize = new System.Drawing.Size(30, 30);
            this.petHomebtn.Location = new System.Drawing.Point(0, 177);
            this.petHomebtn.Name = "petHomebtn";
            this.petHomebtn.Size = new System.Drawing.Size(275, 45);
            this.petHomebtn.TabIndex = 23;
            this.petHomebtn.Text = "Pets";
            this.petHomebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // medbtn
            // 
            this.medbtn.Animated = true;
            this.medbtn.BackColor = System.Drawing.Color.Transparent;
            this.medbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.medbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.medbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.medbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.medbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.medbtn.FillColor = System.Drawing.Color.Transparent;
            this.medbtn.Font = new System.Drawing.Font("Graphik Arabic Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medbtn.ForeColor = System.Drawing.Color.Black;
            this.medbtn.Location = new System.Drawing.Point(-3, 240);
            this.medbtn.Name = "medbtn";
            this.medbtn.Size = new System.Drawing.Size(278, 45);
            this.medbtn.TabIndex = 24;
            this.medbtn.Text = "Medical Care";
            this.medbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AllpetTable
            // 
            this.AllpetTable.AllowUserToAddRows = false;
            this.AllpetTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AllpetTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllpetTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllpetTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.AllpetTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllpetTable.Location = new System.Drawing.Point(312, 135);
            this.AllpetTable.Name = "AllpetTable";
            this.AllpetTable.ReadOnly = true;
            this.AllpetTable.RowHeadersVisible = false;
            this.AllpetTable.RowHeadersWidth = 51;
            this.AllpetTable.RowTemplate.Height = 26;
            this.AllpetTable.Size = new System.Drawing.Size(1111, 665);
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
            // AllPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.AllpetTable);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petType);
            this.Name = "AllPet";
            this.Text = "AllPet";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllpetTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox petType;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button Home;
        private Guna.UI2.WinForms.Guna2Button invoicbtn;
        private Guna.UI2.WinForms.Guna2Button petHomebtn;
        private Guna.UI2.WinForms.Guna2Button medbtn;
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
    }
}