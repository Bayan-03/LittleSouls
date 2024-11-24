namespace LittleSouls
{
    partial class storageForm
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
            this.btn_Save = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboBoxStorgeCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.littleSoulsDataSet = new LittleSouls.littleSoulsDataSet();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageTableAdapter = new LittleSouls.littleSoulsDataSetTableAdapters.storageTableAdapter();
            this.guna2Button = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewStorage = new System.Windows.Forms.DataGridView();
            this.btn_Save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.btn_Save.Controls.Add(this.guna2HtmlLabel1);
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Save.Location = new System.Drawing.Point(0, 0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(1435, 63);
            this.btn_Save.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(636, 22);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(162, 29);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "LITTLE SOULS";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(168)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(952, 104);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(147, 34);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Categories";
            // 
            // ComboBoxStorgeCategories
            // 
            this.ComboBoxStorgeCategories.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxStorgeCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxStorgeCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxStorgeCategories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStorgeCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxStorgeCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxStorgeCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxStorgeCategories.ItemHeight = 30;
            this.ComboBoxStorgeCategories.Location = new System.Drawing.Point(1105, 104);
            this.ComboBoxStorgeCategories.Name = "ComboBoxStorgeCategories";
            this.ComboBoxStorgeCategories.Size = new System.Drawing.Size(270, 36);
            this.ComboBoxStorgeCategories.TabIndex = 2;
            this.ComboBoxStorgeCategories.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStorgeCategories_SelectedIndexChanged);
            // 
            // littleSoulsDataSet
            // 
            this.littleSoulsDataSet.DataSetName = "littleSoulsDataSet";
            this.littleSoulsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // guna2Button
            // 
            this.guna2Button.BorderRadius = 15;
            this.guna2Button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button.Font = new System.Drawing.Font("Graphik Arabic SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button.ForeColor = System.Drawing.Color.White;
            this.guna2Button.Location = new System.Drawing.Point(627, 722);
            this.guna2Button.Name = "guna2Button";
            this.guna2Button.Size = new System.Drawing.Size(180, 45);
            this.guna2Button.TabIndex = 4;
            this.guna2Button.Text = "Save";
            this.guna2Button.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridViewStorage
            // 
            this.dataGridViewStorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStorage.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Graphik Arabic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStorage.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStorage.Location = new System.Drawing.Point(48, 175);
            this.dataGridViewStorage.Name = "dataGridViewStorage";
            this.dataGridViewStorage.ReadOnly = true;
            this.dataGridViewStorage.RowHeadersWidth = 51;
            this.dataGridViewStorage.RowTemplate.Height = 35;
            this.dataGridViewStorage.Size = new System.Drawing.Size(1338, 443);
            this.dataGridViewStorage.TabIndex = 8;
            // 
            // storageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.dataGridViewStorage);
            this.Controls.Add(this.guna2Button);
            this.Controls.Add(this.ComboBoxStorgeCategories);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_Save);
            this.Name = "storageForm";
            this.Text = "storageForm";
            this.Load += new System.EventHandler(this.storgeForm_Load);
            this.btn_Save.ResumeLayout(false);
            this.btn_Save.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.littleSoulsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel btn_Save;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxStorgeCategories;
        private littleSoulsDataSet littleSoulsDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private littleSoulsDataSetTableAdapters.storageTableAdapter storageTableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button;
        private System.Windows.Forms.DataGridView dataGridViewStorage;
    }
}