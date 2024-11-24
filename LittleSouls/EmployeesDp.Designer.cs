namespace LittleSouls
{
    partial class EmployeesDp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tb_panal = new Guna.UI2.WinForms.Guna2Panel();
            this.SopjectLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Tb_panal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployTable)).BeginInit();
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
            this.SopjectLable.Location = new System.Drawing.Point(91, 29);
            this.SopjectLable.Name = "SopjectLable";
            this.SopjectLable.Size = new System.Drawing.Size(203, 32);
            this.SopjectLable.TabIndex = 5;
            this.SopjectLable.Text = "Employees";
            this.SopjectLable.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SopjectLable.Click += new System.EventHandler(this.SopjectLable_Click);
            // 
            // AllEmployTable
            // 
            this.AllEmployTable.AllowUserToAddRows = false;
            this.AllEmployTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.AllEmployTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllEmployTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllEmployTable.DefaultCellStyle = dataGridViewCellStyle12;
            this.AllEmployTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AllEmployTable.Location = new System.Drawing.Point(119, 149);
            this.AllEmployTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllEmployTable.Name = "AllEmployTable";
            this.AllEmployTable.ReadOnly = true;
            this.AllEmployTable.RowHeadersVisible = false;
            this.AllEmployTable.RowHeadersWidth = 51;
            this.AllEmployTable.RowTemplate.Height = 26;
            this.AllEmployTable.Size = new System.Drawing.Size(1198, 540);
            this.AllEmployTable.TabIndex = 39;
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
            this.guna2Button1.Location = new System.Drawing.Point(1247, 20);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(126, 45);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Go Back";
            // 
            // EmployeesDp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.ClientSize = new System.Drawing.Size(1437, 838);
            this.Controls.Add(this.AllEmployTable);
            this.Controls.Add(this.Tb_panal);
            this.Name = "EmployeesDp";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeesDp_Load);
            this.Tb_panal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllEmployTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Tb_panal;
        private Guna.UI2.WinForms.Guna2HtmlLabel SopjectLable;
        private Guna.UI2.WinForms.Guna2DataGridView AllEmployTable;
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