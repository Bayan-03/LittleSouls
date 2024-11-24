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
            this.medicalRecodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.littleSoulsDataSet = new LittleSouls.littleSoulsDataSet();
            this.medicalRecodTableAdapter = new LittleSouls.littleSoulsDataSetTableAdapters.medicalRecodTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.navBarPanel1 = new LittleSouls.NavBarPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vaccinations = new Guna.UI2.WinForms.Guna2TextBox();
            this.treatment = new Guna.UI2.WinForms.Guna2TextBox();
            this.surgeryinfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.veteinarianId = new Guna.UI2.WinForms.Guna2TextBox();
            this.diagnos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.petid = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
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
            this.UpdateRecord.BorderRadius = 18;
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
            this.UpdateRecord.Location = new System.Drawing.Point(1165, 661);
            this.UpdateRecord.Name = "UpdateRecord";
            this.UpdateRecord.Size = new System.Drawing.Size(198, 38);
            this.UpdateRecord.TabIndex = 30;
            this.UpdateRecord.Text = "Update Record";
            this.UpdateRecord.Click += new System.EventHandler(this.UpdateRecord_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(68, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1367, 45);
            this.guna2Panel1.TabIndex = 70;
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
            this.label1.Location = new System.Drawing.Point(154, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 42);
            this.label1.TabIndex = 73;
            this.label1.Text = "ADD MEDICAL RECORD";
            // 
            // navBarPanel1
            // 
            this.navBarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel1.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.navBarPanel1.Name = "navBarPanel1";
            this.navBarPanel1.Size = new System.Drawing.Size(68, 830);
            this.navBarPanel1.TabIndex = 74;
            this.navBarPanel1.showHomeForm += new System.EventHandler(this.navBarPanel1_showHomeForm);
            this.navBarPanel1.showPetsForm += new System.EventHandler(this.navBarPanel1_showPetsForm);
            this.navBarPanel1.showMedicalCareForm += new System.EventHandler(this.navBarPanel1_showMedicalCareForm);
            this.navBarPanel1.showInvoiceForm += new System.EventHandler(this.navBarPanel1_showInvoiceForm);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(328, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Pet ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label4.Location = new System.Drawing.Point(859, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "Treatment Provided:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label5.Location = new System.Drawing.Point(859, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "surgery Information:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label6.Location = new System.Drawing.Point(269, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 24);
            this.label6.TabIndex = 80;
            this.label6.Text = "Vaccinations:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label7.Location = new System.Drawing.Point(904, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 24);
            this.label7.TabIndex = 81;
            this.label7.Text = "Veteinarian ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.label8.Location = new System.Drawing.Point(300, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 82;
            this.label8.Text = "Diagnosis:";
            // 
            // vaccinations
            // 
            this.vaccinations.Animated = true;
            this.vaccinations.BackColor = System.Drawing.Color.Transparent;
            this.vaccinations.BorderRadius = 20;
            this.vaccinations.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.vaccinations.DefaultText = "";
            this.vaccinations.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.vaccinations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.vaccinations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vaccinations.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.vaccinations.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vaccinations.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaccinations.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.vaccinations.Location = new System.Drawing.Point(422, 365);
            this.vaccinations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vaccinations.Name = "vaccinations";
            this.vaccinations.PasswordChar = '\0';
            this.vaccinations.PlaceholderText = "";
            this.vaccinations.SelectedText = "";
            this.vaccinations.Size = new System.Drawing.Size(259, 45);
            this.vaccinations.TabIndex = 84;
            // 
            // treatment
            // 
            this.treatment.Animated = true;
            this.treatment.BackColor = System.Drawing.Color.Transparent;
            this.treatment.BorderRadius = 20;
            this.treatment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.treatment.DefaultText = "";
            this.treatment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.treatment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.treatment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.treatment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.treatment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.treatment.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.treatment.Location = new System.Drawing.Point(1087, 258);
            this.treatment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treatment.Name = "treatment";
            this.treatment.PasswordChar = '\0';
            this.treatment.PlaceholderText = "";
            this.treatment.SelectedText = "";
            this.treatment.Size = new System.Drawing.Size(259, 45);
            this.treatment.TabIndex = 85;
            // 
            // surgeryinfo
            // 
            this.surgeryinfo.Animated = true;
            this.surgeryinfo.BackColor = System.Drawing.Color.Transparent;
            this.surgeryinfo.BorderRadius = 20;
            this.surgeryinfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surgeryinfo.DefaultText = "";
            this.surgeryinfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surgeryinfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surgeryinfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surgeryinfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surgeryinfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surgeryinfo.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgeryinfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surgeryinfo.Location = new System.Drawing.Point(1087, 368);
            this.surgeryinfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surgeryinfo.Name = "surgeryinfo";
            this.surgeryinfo.PasswordChar = '\0';
            this.surgeryinfo.PlaceholderText = "";
            this.surgeryinfo.SelectedText = "";
            this.surgeryinfo.Size = new System.Drawing.Size(259, 45);
            this.surgeryinfo.TabIndex = 86;
            // 
            // veteinarianId
            // 
            this.veteinarianId.Animated = true;
            this.veteinarianId.BackColor = System.Drawing.Color.Transparent;
            this.veteinarianId.BorderRadius = 20;
            this.veteinarianId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.veteinarianId.DefaultText = "";
            this.veteinarianId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.veteinarianId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.veteinarianId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.veteinarianId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.veteinarianId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.veteinarianId.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veteinarianId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.veteinarianId.Location = new System.Drawing.Point(1087, 453);
            this.veteinarianId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.veteinarianId.Name = "veteinarianId";
            this.veteinarianId.PasswordChar = '\0';
            this.veteinarianId.PlaceholderText = "";
            this.veteinarianId.SelectedText = "";
            this.veteinarianId.Size = new System.Drawing.Size(259, 45);
            this.veteinarianId.TabIndex = 87;
            // 
            // diagnos
            // 
            this.diagnos.BackColor = System.Drawing.Color.Transparent;
            this.diagnos.BorderRadius = 20;
            this.diagnos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.diagnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diagnos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diagnos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diagnos.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.diagnos.ItemHeight = 30;
            this.diagnos.Items.AddRange(new object[] {
            "Need Surgery",
            "Need medisen",
            "Healthy"});
            this.diagnos.Location = new System.Drawing.Point(422, 461);
            this.diagnos.Name = "diagnos";
            this.diagnos.Size = new System.Drawing.Size(170, 36);
            this.diagnos.TabIndex = 88;
            // 
            // petid
            // 
            this.petid.Animated = true;
            this.petid.BackColor = System.Drawing.Color.Transparent;
            this.petid.BorderRadius = 20;
            this.petid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.petid.DefaultText = "";
            this.petid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.petid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.petid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.petid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.petid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petid.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petid.Location = new System.Drawing.Point(422, 258);
            this.petid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.petid.Name = "petid";
            this.petid.PasswordChar = '\0';
            this.petid.PlaceholderText = "";
            this.petid.SelectedText = "";
            this.petid.Size = new System.Drawing.Size(170, 45);
            this.petid.TabIndex = 75;
            // 
            // PetsExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.diagnos);
            this.Controls.Add(this.veteinarianId);
            this.Controls.Add(this.surgeryinfo);
            this.Controls.Add(this.treatment);
            this.Controls.Add(this.vaccinations);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.petid);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.navBarPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateRecord);
            this.Name = "PetsExamination";
            this.Text = "PetsExamination";
            this.Load += new System.EventHandler(this.PetsExamination_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
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
        private System.Windows.Forms.BindingSource littleSoulsDataSetBindingSource;
        private littleSoulsDataSet littleSoulsDataSet;
        private System.Windows.Forms.BindingSource medicalRecodBindingSource;
        private littleSoulsDataSetTableAdapters.medicalRecodTableAdapter medicalRecodTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private NavBarPanel navBarPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox vaccinations;
        private Guna.UI2.WinForms.Guna2TextBox treatment;
        private Guna.UI2.WinForms.Guna2TextBox surgeryinfo;
        private Guna.UI2.WinForms.Guna2TextBox veteinarianId;
        private Guna.UI2.WinForms.Guna2ComboBox diagnos;
        private Guna.UI2.WinForms.Guna2TextBox petid;
    }
}