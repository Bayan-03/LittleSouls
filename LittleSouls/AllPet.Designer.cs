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
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.petTableAdapter = new LittleSouls.littleSoulsDataSetTableAdapters.petTableAdapter();
            this.petBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageTableAdapter = new LittleSouls.littleSoulsDataSetTableAdapters.storageTableAdapter();
            this.petBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.AllpetTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.petBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.petBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource5)).BeginInit();
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(938, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
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
            this.guna2Panel1.Location = new System.Drawing.Point(68, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1367, 45);
            this.guna2Panel1.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label11.Location = new System.Drawing.Point(598, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 29);
            this.label11.TabIndex = 37;
            this.label11.Text = "LITTLE SOULS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(130, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 42);
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
            // petBindingSource5
            // 
            this.petBindingSource5.DataMember = "pet";
            this.petBindingSource5.DataSource = this.littleSoulsDataSetBindingSource;
            // 
            // navBarPanel1
            // 
            this.navBarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel1.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.navBarPanel1.Name = "navBarPanel1";
            this.navBarPanel1.Size = new System.Drawing.Size(68, 830);
            this.navBarPanel1.TabIndex = 41;
            this.navBarPanel1.showHomeForm += new System.EventHandler(this.navBarPanel1_showHomeForm);
            this.navBarPanel1.showPetsForm += new System.EventHandler(this.navBarPanel1_showPetsForm);
            this.navBarPanel1.showMedicalCareForm += new System.EventHandler(this.navBarPanel1_showMedicalCareForm);
            this.navBarPanel1.showInvoiceForm += new System.EventHandler(this.navBarPanel1_showInvoiceForm);
            // 
            // AllPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.navBarPanel1);
            this.Controls.Add(this.AllpetTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petType);
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
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource5)).EndInit();
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
        private System.Windows.Forms.BindingSource petBindingSource4;
        private System.Windows.Forms.BindingSource littleSoulsDataSetBindingSource;
        private System.Windows.Forms.BindingSource petBindingSource3;
        private System.Windows.Forms.Label label11;
        private NavBarPanel navBarPanel1;
        private System.Windows.Forms.BindingSource petBindingSource5;
    }
}