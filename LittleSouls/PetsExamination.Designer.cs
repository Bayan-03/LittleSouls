namespace LittleSouls
{
    partial class PetsExamination
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
            this.UpdateRecord = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.midecal = new System.Windows.Forms.DataGridView();
            this.recordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfExaminationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentsProvidedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.surgeryInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vetetinarianIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalRecodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSet = new LittleSouls.littleSoulsDataSet();
            this.medicalRecodTableAdapter = new LittleSouls.littleSoulsDataSetTableAdapters.medicalRecodTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.navBarPanel1 = new LittleSouls.NavBarPanel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.midecal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateRecord
            // 
            this.UpdateRecord.Animated = true;
            this.UpdateRecord.AutoRoundedCorners = true;
            this.UpdateRecord.BackColor = System.Drawing.Color.Transparent;
            this.UpdateRecord.BorderRadius = 21;
            this.UpdateRecord.DefaultAutoSize = true;
            this.UpdateRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateRecord.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.UpdateRecord.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.UpdateRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.UpdateRecord.Location = new System.Drawing.Point(1498, 826);
            this.UpdateRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(232, 44);
            this.UpdateRecord.TabIndex = 30;
            this.UpdateRecord.Text = "Update Record";
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
            this.guna2Panel1.TabIndex = 70;
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
            // midecal
            // 
            this.midecal.AutoGenerateColumns = false;
            this.midecal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.midecal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.midecal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIdDataGridViewTextBoxColumn,
            this.petIdDataGridViewTextBoxColumn,
            this.dateOfExaminationDataGridViewTextBoxColumn,
            this.treatmentsProvidedDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.surgeryInformationDataGridViewTextBoxColumn,
            this.vaccinationsDataGridViewTextBoxColumn,
            this.vetetinarianIdDataGridViewTextBoxColumn});
            this.midecal.DataSource = this.medicalRecodBindingSource;
            this.midecal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.midecal.Location = new System.Drawing.Point(242, 251);
            this.midecal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.midecal.Name = "midecal";
            this.midecal.RowHeadersWidth = 51;
            this.midecal.RowTemplate.Height = 26;
            this.midecal.Size = new System.Drawing.Size(1522, 534);
            this.midecal.TabIndex = 72;
            // 
            // recordIdDataGridViewTextBoxColumn
            // 
            this.recordIdDataGridViewTextBoxColumn.DataPropertyName = "recordId";
            this.recordIdDataGridViewTextBoxColumn.HeaderText = "recordId";
            this.recordIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordIdDataGridViewTextBoxColumn.Name = "recordIdDataGridViewTextBoxColumn";
            this.recordIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petIdDataGridViewTextBoxColumn
            // 
            this.petIdDataGridViewTextBoxColumn.DataPropertyName = "petId";
            this.petIdDataGridViewTextBoxColumn.HeaderText = "petId";
            this.petIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petIdDataGridViewTextBoxColumn.Name = "petIdDataGridViewTextBoxColumn";
            // 
            // dateOfExaminationDataGridViewTextBoxColumn
            // 
            this.dateOfExaminationDataGridViewTextBoxColumn.DataPropertyName = "dateOfExamination";
            this.dateOfExaminationDataGridViewTextBoxColumn.HeaderText = "dateOfExamination";
            this.dateOfExaminationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfExaminationDataGridViewTextBoxColumn.Name = "dateOfExaminationDataGridViewTextBoxColumn";
            // 
            // treatmentsProvidedDataGridViewTextBoxColumn
            // 
            this.treatmentsProvidedDataGridViewTextBoxColumn.DataPropertyName = "treatmentsProvided";
            this.treatmentsProvidedDataGridViewTextBoxColumn.HeaderText = "treatmentsProvided";
            this.treatmentsProvidedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.treatmentsProvidedDataGridViewTextBoxColumn.Name = "treatmentsProvidedDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            this.diagnosisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // surgeryInformationDataGridViewTextBoxColumn
            // 
            this.surgeryInformationDataGridViewTextBoxColumn.DataPropertyName = "surgeryInformation";
            this.surgeryInformationDataGridViewTextBoxColumn.HeaderText = "surgeryInformation";
            this.surgeryInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surgeryInformationDataGridViewTextBoxColumn.Name = "surgeryInformationDataGridViewTextBoxColumn";
            // 
            // vaccinationsDataGridViewTextBoxColumn
            // 
            this.vaccinationsDataGridViewTextBoxColumn.DataPropertyName = "vaccinations";
            this.vaccinationsDataGridViewTextBoxColumn.HeaderText = "vaccinations";
            this.vaccinationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vaccinationsDataGridViewTextBoxColumn.Name = "vaccinationsDataGridViewTextBoxColumn";
            // 
            // vetetinarianIdDataGridViewTextBoxColumn
            // 
            this.vetetinarianIdDataGridViewTextBoxColumn.DataPropertyName = "vetetinarianId";
            this.vetetinarianIdDataGridViewTextBoxColumn.HeaderText = "vetetinarianId";
            this.vetetinarianIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vetetinarianIdDataGridViewTextBoxColumn.Name = "vetetinarianIdDataGridViewTextBoxColumn";
            // 
            // medicalRecodBindingSource
            // 
            this.medicalRecodBindingSource.DataMember = "medicalRecod";
            this.medicalRecodBindingSource.DataSource = this.littleSoulsDataSetBindingSource;
            // 
            // littleSoulsDataSetBindingSource
            // 
            this.littleSoulsDataSetBindingSource.DataSource = this.littleSoulsDataSet;
            this.littleSoulsDataSetBindingSource.Position = 0;
            // 
            // littleSoulsDataSet
            // 
            this.littleSoulsDataSet.DataSetName = "littleSoulsDataSet";
            this.littleSoulsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalRecodTableAdapter
            // 
            this.medicalRecodTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(198, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 52);
            this.label1.TabIndex = 73;
            this.label1.Text = "ADD MEDICAL RECORD";
            // 
            // navBarPanel1
            // 
            this.navBarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel1.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel1.Name = "navBarPanel1";
            this.navBarPanel1.Size = new System.Drawing.Size(88, 1038);
            this.navBarPanel1.TabIndex = 74;
            this.navBarPanel1.showHomeForm += new System.EventHandler(this.navBarPanel1_showHomeForm);
            this.navBarPanel1.showPetsForm += new System.EventHandler(this.navBarPanel1_showPetsForm);
            this.navBarPanel1.showMedicalCareForm += new System.EventHandler(this.navBarPanel1_showMedicalCareForm);
            // 
            // PetsExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.ClientSize = new System.Drawing.Size(1845, 1038);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.navBarPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.midecal);
            this.Controls.Add(this.UpdateRecord);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PetsExamination";
            this.Text = "PetsExamination";
            this.Load += new System.EventHandler(this.PetsExamination_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.midecal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton UpdateRecord;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView midecal;
        private System.Windows.Forms.BindingSource littleSoulsDataSetBindingSource;
        private littleSoulsDataSet littleSoulsDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfExaminationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentsProvidedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgeryInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccinationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vetetinarianIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicalRecodBindingSource;
        private littleSoulsDataSetTableAdapters.medicalRecodTableAdapter medicalRecodTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private NavBarPanel navBarPanel1;
    }
}