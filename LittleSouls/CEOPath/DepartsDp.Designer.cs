namespace LittleSouls
{
    partial class DepartsDp
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
            this.AllEmployTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Emp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yearofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JopTitle = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.EmpStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tb_panal = new Guna.UI2.WinForms.Guna2Panel();
            this.SopjectLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployTable)).BeginInit();
            this.Tb_panal.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllEmployTable
            // 
            this.AllEmployTable.AllowUserToAddRows = false;
            this.AllEmployTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.AllEmployTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllEmployTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.AllEmployTable.ColumnHeadersHeight = 36;
            this.AllEmployTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllEmployTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_ID,
            this.Empname,
            this.Yearofbirth,
            this.DepartID,
            this.JopTitle,
            this.PhoneNumber,
            this.Email,
            this.EmpSalary,
            this.petimage,
            this.EmpStatus});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllEmployTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.AllEmployTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllEmployTable.Location = new System.Drawing.Point(118, 130);
            this.AllEmployTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllEmployTable.Name = "AllEmployTable";
            this.AllEmployTable.ReadOnly = true;
            this.AllEmployTable.RowHeadersVisible = false;
            this.AllEmployTable.RowHeadersWidth = 51;
            this.AllEmployTable.RowTemplate.Height = 26;
            this.AllEmployTable.Size = new System.Drawing.Size(1198, 540);
            this.AllEmployTable.TabIndex = 37;
            this.AllEmployTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AllEmployTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AllEmployTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AllEmployTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AllEmployTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AllEmployTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AllEmployTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllEmployTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AllEmployTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AllEmployTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AllEmployTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AllEmployTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AllEmployTable.ThemeStyle.HeaderStyle.Height = 36;
            this.AllEmployTable.ThemeStyle.ReadOnly = true;
            this.AllEmployTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AllEmployTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AllEmployTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AllEmployTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllEmployTable.ThemeStyle.RowsStyle.Height = 26;
            this.AllEmployTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllEmployTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AllEmployTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployTable_CellContentClick);
            // 
            // Emp_ID
            // 
            this.Emp_ID.HeaderText = "ID";
            this.Emp_ID.MinimumWidth = 6;
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.ReadOnly = true;
            // 
            // Empname
            // 
            this.Empname.HeaderText = "Name";
            this.Empname.MinimumWidth = 6;
            this.Empname.Name = "Empname";
            this.Empname.ReadOnly = true;
            // 
            // Yearofbirth
            // 
            this.Yearofbirth.HeaderText = "Birth Date";
            this.Yearofbirth.MinimumWidth = 6;
            this.Yearofbirth.Name = "Yearofbirth";
            this.Yearofbirth.ReadOnly = true;
            // 
            // DepartID
            // 
            this.DepartID.HeaderText = "DepartID";
            this.DepartID.MinimumWidth = 6;
            this.DepartID.Name = "DepartID";
            this.DepartID.ReadOnly = true;
            // 
            // JopTitle
            // 
            this.JopTitle.HeaderText = "JopTitle";
            this.JopTitle.MinimumWidth = 6;
            this.JopTitle.Name = "JopTitle";
            this.JopTitle.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // EmpSalary
            // 
            this.EmpSalary.HeaderText = "Salary";
            this.EmpSalary.MinimumWidth = 6;
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.ReadOnly = true;
            // 
            // petimage
            // 
            this.petimage.HeaderText = "photo";
            this.petimage.MinimumWidth = 6;
            this.petimage.Name = "petimage";
            this.petimage.ReadOnly = true;
            // 
            // EmpStatus
            // 
            this.EmpStatus.HeaderText = "Status";
            this.EmpStatus.MinimumWidth = 6;
            this.EmpStatus.Name = "EmpStatus";
            this.EmpStatus.ReadOnly = true;
            // 
            // Tb_panal
            // 
            this.Tb_panal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.Tb_panal.Controls.Add(this.guna2Button1);
            this.Tb_panal.Controls.Add(this.SopjectLable);
            this.Tb_panal.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.SopjectLable.Font = new System.Drawing.Font("Graphik Arabic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SopjectLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.SopjectLable.Location = new System.Drawing.Point(74, 29);
            this.SopjectLable.Name = "SopjectLable";
            this.SopjectLable.Size = new System.Drawing.Size(396, 32);
            this.SopjectLable.TabIndex = 5;
            this.SopjectLable.Text = "Employees Of Department";
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
            this.guna2Button1.Location = new System.Drawing.Point(1244, 16);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(126, 45);
            this.guna2Button1.TabIndex = 41;
            this.guna2Button1.Text = "Go Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DepartsDp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.ClientSize = new System.Drawing.Size(1437, 838);
            this.Controls.Add(this.Tb_panal);
            this.Controls.Add(this.AllEmployTable);
            this.Name = "DepartsDp";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployTable)).EndInit();
            this.Tb_panal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView AllEmployTable;
        private Guna.UI2.WinForms.Guna2Panel Tb_panal;
        private Guna.UI2.WinForms.Guna2HtmlLabel SopjectLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yearofbirth;
        private System.Windows.Forms.DataGridViewComboBoxColumn DepartID;
        private System.Windows.Forms.DataGridViewComboBoxColumn JopTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSalary;
        private System.Windows.Forms.DataGridViewImageColumn petimage;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpStatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}