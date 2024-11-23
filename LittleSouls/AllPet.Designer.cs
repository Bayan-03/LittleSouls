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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.petType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSet = new LittleSouls.littleSoulsDataSet();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.SideBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.petTableAdapter = new LittleSouls.littleSoulsDataSetTableAdapters.petTableAdapter();
            this.petBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageTableAdapter = new LittleSouls.littleSoulsDataSetTableAdapters.storageTableAdapter();
            this.petBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.AllpetTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.petIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petBreedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petSpeciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfArraivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.healthStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.petSetterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adopterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adoptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllpetTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource3)).BeginInit();
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
            // petBindingSource
            // 
            this.petBindingSource.DataMember = "pet";
            this.petBindingSource.DataSource = this.littleSoulsDataSet;
            // 
            // littleSoulsDataSet
            // 
            this.littleSoulsDataSet.DataSetName = "littleSoulsDataSet";
            this.littleSoulsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.guna2Panel1.Controls.Add(this.label11);
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
            // petTableAdapter
            // 
            this.petTableAdapter.ClearBeforeFill = true;
            // 
            // petBindingSource1
            // 
            this.petBindingSource1.DataMember = "pet";
            this.petBindingSource1.DataSource = this.littleSoulsDataSet;
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "storage";
            this.storageBindingSource.DataSource = this.littleSoulsDataSet;
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // petBindingSource2
            // 
            this.petBindingSource2.DataMember = "pet";
            this.petBindingSource2.DataSource = this.littleSoulsDataSet;
            // 
            // AllpetTable
            // 
            this.AllpetTable.AllowUserToAddRows = false;
            this.AllpetTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AllpetTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AllpetTable.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllpetTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AllpetTable.ColumnHeadersHeight = 19;
            this.AllpetTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllpetTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petIdDataGridViewTextBoxColumn,
            this.yearOfBirthDataGridViewTextBoxColumn,
            this.petSexDataGridViewTextBoxColumn,
            this.petBreedDataGridViewTextBoxColumn,
            this.petSpeciesDataGridViewTextBoxColumn,
            this.dateOfArraivalDataGridViewTextBoxColumn,
            this.petColorDataGridViewTextBoxColumn,
            this.healthStatusDataGridViewTextBoxColumn,
            this.petStateDataGridViewTextBoxColumn,
            this.petImageDataGridViewImageColumn,
            this.petSetterDataGridViewTextBoxColumn,
            this.adopterDataGridViewTextBoxColumn,
            this.adoptDateDataGridViewTextBoxColumn});
            this.AllpetTable.DataSource = this.petBindingSource4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllpetTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.AllpetTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllpetTable.Location = new System.Drawing.Point(124, 225);
            this.AllpetTable.Name = "AllpetTable";
            this.AllpetTable.ReadOnly = true;
            this.AllpetTable.RowHeadersVisible = false;
            this.AllpetTable.RowHeadersWidth = 51;
            this.AllpetTable.RowTemplate.Height = 26;
            this.AllpetTable.Size = new System.Drawing.Size(1240, 330);
            this.AllpetTable.TabIndex = 40;
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
            this.AllpetTable.ThemeStyle.HeaderStyle.Height = 19;
            this.AllpetTable.ThemeStyle.ReadOnly = true;
            this.AllpetTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AllpetTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllpetTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AllpetTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllpetTable.ThemeStyle.RowsStyle.Height = 26;
            this.AllpetTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllpetTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllpetTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllpetTable_CellContentClick);
            // 
            // petIdDataGridViewTextBoxColumn
            // 
            this.petIdDataGridViewTextBoxColumn.DataPropertyName = "petId";
            this.petIdDataGridViewTextBoxColumn.HeaderText = "petId";
            this.petIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petIdDataGridViewTextBoxColumn.Name = "petIdDataGridViewTextBoxColumn";
            this.petIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearOfBirthDataGridViewTextBoxColumn
            // 
            this.yearOfBirthDataGridViewTextBoxColumn.DataPropertyName = "yearOfBirth";
            this.yearOfBirthDataGridViewTextBoxColumn.HeaderText = "yearOfBirth";
            this.yearOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearOfBirthDataGridViewTextBoxColumn.Name = "yearOfBirthDataGridViewTextBoxColumn";
            this.yearOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petSexDataGridViewTextBoxColumn
            // 
            this.petSexDataGridViewTextBoxColumn.DataPropertyName = "petSex";
            this.petSexDataGridViewTextBoxColumn.HeaderText = "petSex";
            this.petSexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petSexDataGridViewTextBoxColumn.Name = "petSexDataGridViewTextBoxColumn";
            this.petSexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petBreedDataGridViewTextBoxColumn
            // 
            this.petBreedDataGridViewTextBoxColumn.DataPropertyName = "petBreed";
            this.petBreedDataGridViewTextBoxColumn.HeaderText = "petBreed";
            this.petBreedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petBreedDataGridViewTextBoxColumn.Name = "petBreedDataGridViewTextBoxColumn";
            this.petBreedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petSpeciesDataGridViewTextBoxColumn
            // 
            this.petSpeciesDataGridViewTextBoxColumn.DataPropertyName = "petSpecies";
            this.petSpeciesDataGridViewTextBoxColumn.HeaderText = "petSpecies";
            this.petSpeciesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petSpeciesDataGridViewTextBoxColumn.Name = "petSpeciesDataGridViewTextBoxColumn";
            this.petSpeciesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfArraivalDataGridViewTextBoxColumn
            // 
            this.dateOfArraivalDataGridViewTextBoxColumn.DataPropertyName = "dateOfArraival";
            this.dateOfArraivalDataGridViewTextBoxColumn.HeaderText = "dateOfArraival";
            this.dateOfArraivalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfArraivalDataGridViewTextBoxColumn.Name = "dateOfArraivalDataGridViewTextBoxColumn";
            this.dateOfArraivalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petColorDataGridViewTextBoxColumn
            // 
            this.petColorDataGridViewTextBoxColumn.DataPropertyName = "petColor";
            this.petColorDataGridViewTextBoxColumn.HeaderText = "petColor";
            this.petColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petColorDataGridViewTextBoxColumn.Name = "petColorDataGridViewTextBoxColumn";
            this.petColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // healthStatusDataGridViewTextBoxColumn
            // 
            this.healthStatusDataGridViewTextBoxColumn.DataPropertyName = "healthStatus";
            this.healthStatusDataGridViewTextBoxColumn.HeaderText = "healthStatus";
            this.healthStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.healthStatusDataGridViewTextBoxColumn.Name = "healthStatusDataGridViewTextBoxColumn";
            this.healthStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petStateDataGridViewTextBoxColumn
            // 
            this.petStateDataGridViewTextBoxColumn.DataPropertyName = "petState";
            this.petStateDataGridViewTextBoxColumn.HeaderText = "petState";
            this.petStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petStateDataGridViewTextBoxColumn.Name = "petStateDataGridViewTextBoxColumn";
            this.petStateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petImageDataGridViewImageColumn
            // 
            this.petImageDataGridViewImageColumn.DataPropertyName = "petImage";
            this.petImageDataGridViewImageColumn.HeaderText = "petImage";
            this.petImageDataGridViewImageColumn.MinimumWidth = 6;
            this.petImageDataGridViewImageColumn.Name = "petImageDataGridViewImageColumn";
            this.petImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // petSetterDataGridViewTextBoxColumn
            // 
            this.petSetterDataGridViewTextBoxColumn.DataPropertyName = "petSetter";
            this.petSetterDataGridViewTextBoxColumn.HeaderText = "petSetter";
            this.petSetterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petSetterDataGridViewTextBoxColumn.Name = "petSetterDataGridViewTextBoxColumn";
            this.petSetterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adopterDataGridViewTextBoxColumn
            // 
            this.adopterDataGridViewTextBoxColumn.DataPropertyName = "adopter";
            this.adopterDataGridViewTextBoxColumn.HeaderText = "adopter";
            this.adopterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adopterDataGridViewTextBoxColumn.Name = "adopterDataGridViewTextBoxColumn";
            this.adopterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adoptDateDataGridViewTextBoxColumn
            // 
            this.adoptDateDataGridViewTextBoxColumn.DataPropertyName = "adoptDate";
            this.adoptDateDataGridViewTextBoxColumn.HeaderText = "adoptDate";
            this.adoptDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adoptDateDataGridViewTextBoxColumn.Name = "adoptDateDataGridViewTextBoxColumn";
            this.adoptDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petBindingSource4
            // 
            this.petBindingSource4.DataMember = "pet";
            this.petBindingSource4.DataSource = this.littleSoulsDataSet;
            // 
            // littleSoulsDataSetBindingSource
            // 
            this.littleSoulsDataSetBindingSource.DataSource = this.littleSoulsDataSet;
            this.littleSoulsDataSetBindingSource.Position = 0;
            // 
            // petBindingSource3
            // 
            this.petBindingSource3.DataMember = "pet";
            this.petBindingSource3.DataSource = this.littleSoulsDataSetBindingSource;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label11.Location = new System.Drawing.Point(598, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 27);
            this.label11.TabIndex = 37;
            this.label11.Text = "LITTLE SOULS";
            // 
            // AllPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.AllpetTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petType);
            this.Name = "AllPet";
            this.Text = "AllPet";
            this.Load += new System.EventHandler(this.AllPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllpetTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox petType;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientPanel SideBar;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private littleSoulsDataSet littleSoulsDataSet;
        private System.Windows.Forms.BindingSource petBindingSource;
        private littleSoulsDataSetTableAdapters.petTableAdapter petTableAdapter;
        private System.Windows.Forms.BindingSource petBindingSource1;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private littleSoulsDataSetTableAdapters.storageTableAdapter storageTableAdapter;
        private System.Windows.Forms.BindingSource petBindingSource2;
        private Guna.UI2.WinForms.Guna2DataGridView AllpetTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petBreedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petSpeciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfArraivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn healthStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn petImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petSetterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adopterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adoptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource petBindingSource4;
        private System.Windows.Forms.BindingSource littleSoulsDataSetBindingSource;
        private System.Windows.Forms.BindingSource petBindingSource3;
        private System.Windows.Forms.Label label11;
    }
}