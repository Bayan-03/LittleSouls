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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.petType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSet = new LittleSouls.littleSoulsDataSet();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
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
            this.navBarPanel1 = new LittleSouls.NavBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).BeginInit();
            this.guna2Panel1.SuspendLayout();
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
            this.petType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
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
            this.petType.Location = new System.Drawing.Point(1417, 178);
            this.petType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.petType.Name = "petType";
            this.petType.Size = new System.Drawing.Size(373, 36);
            this.petType.TabIndex = 32;
            this.petType.SelectedIndexChanged += new System.EventHandler(this.petType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(1206, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 38);
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
            this.guna2Panel1.Location = new System.Drawing.Point(88, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1757, 56);
            this.guna2Panel1.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label11.Location = new System.Drawing.Point(769, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 32);
            this.label11.TabIndex = 37;
            this.label11.Text = "LITTLE SOULS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(167, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 52);
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.AllpetTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.AllpetTable.AutoGenerateColumns = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllpetTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllpetTable.DefaultCellStyle = dataGridViewCellStyle12;
            this.AllpetTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllpetTable.Location = new System.Drawing.Point(159, 281);
            this.AllpetTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllpetTable.Name = "AllpetTable";
            this.AllpetTable.ReadOnly = true;
            this.AllpetTable.RowHeadersVisible = false;
            this.AllpetTable.RowHeadersWidth = 51;
            this.AllpetTable.RowTemplate.Height = 26;
            this.AllpetTable.Size = new System.Drawing.Size(1594, 412);
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
            // navBarPanel1
            // 
            this.navBarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel1.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel1.Name = "navBarPanel1";
            this.navBarPanel1.Size = new System.Drawing.Size(88, 1038);
            this.navBarPanel1.TabIndex = 41;
            this.navBarPanel1.showHomeForm += new System.EventHandler(this.navBarPanel1_showHomeForm);
            this.navBarPanel1.showPetsForm += new System.EventHandler(this.navBarPanel1_showPetsForm);
            this.navBarPanel1.showMedicalCareForm += new System.EventHandler(this.navBarPanel1_showMedicalCareForm);
            // 
            // AllPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1845, 1038);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.navBarPanel1);
            this.Controls.Add(this.AllpetTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petType);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AllPet";
            this.Text = "AllPet";
            this.Load += new System.EventHandler(this.AllPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
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
        private NavBarPanel navBarPanel1;
    }
}