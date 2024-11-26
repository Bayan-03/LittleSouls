namespace LittleSouls
{
    partial class AddPet
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.BreedCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PetColor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.speciestxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.health = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Arraival = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YearOfBirth = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ADD = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Adoptbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label18 = new System.Windows.Forms.Label();
            this.petgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.petsetter = new Guna.UI2.WinForms.Guna2TextBox();
            this.navBarPanel1 = new LittleSouls.NavBarPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(68, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1367, 45);
            this.guna2Panel1.TabIndex = 72;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label11.Location = new System.Drawing.Point(557, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 29);
            this.label11.TabIndex = 37;
            this.label11.Text = "LITTLE SOULS";
            // 
            // BreedCombo
            // 
            this.BreedCombo.BackColor = System.Drawing.Color.Transparent;
            this.BreedCombo.BorderRadius = 10;
            this.BreedCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BreedCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BreedCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BreedCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BreedCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BreedCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreedCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.BreedCombo.ItemHeight = 30;
            this.BreedCombo.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Chuck",
            "Duck",
            "Fish",
            "Turttel",
            "Bird",
            "Rabbite"});
            this.BreedCombo.Location = new System.Drawing.Point(474, 533);
            this.BreedCombo.Name = "BreedCombo";
            this.BreedCombo.Size = new System.Drawing.Size(191, 36);
            this.BreedCombo.TabIndex = 85;
            this.BreedCombo.SelectedIndexChanged += new System.EventHandler(this.Gendercheck_SelectedIndexChanged);
            // 
            // PetColor
            // 
            this.PetColor.BackColor = System.Drawing.Color.Transparent;
            this.PetColor.BorderRadius = 10;
            this.PetColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PetColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PetColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PetColor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PetColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PetColor.ItemHeight = 30;
            this.PetColor.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Yellow",
            "Orange",
            "Mixed",
            "Gray",
            "Blue",
            "Gold"});
            this.PetColor.Location = new System.Drawing.Point(474, 288);
            this.PetColor.Name = "PetColor";
            this.PetColor.Size = new System.Drawing.Size(186, 36);
            this.PetColor.TabIndex = 78;
            this.PetColor.SelectedIndexChanged += new System.EventHandler(this.PetColor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(872, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 83;
            this.label2.Tag = "";
            this.label2.Text = "Helth State:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label9.Location = new System.Drawing.Point(281, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 32);
            this.label9.TabIndex = 79;
            this.label9.Tag = "";
            this.label9.Text = "Soul\'s Color:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label29.Location = new System.Drawing.Point(890, 293);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(159, 32);
            this.label29.TabIndex = 74;
            this.label29.Text = "Pet Setter:";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label3.Location = new System.Drawing.Point(292, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 77;
            this.label3.Text = "Pet Gender:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label12.Location = new System.Drawing.Point(336, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 32);
            this.label12.TabIndex = 80;
            this.label12.Text = "Species:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label6.Location = new System.Drawing.Point(368, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 75;
            this.label6.Text = "Breed:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // speciestxt
            // 
            this.speciestxt.Animated = true;
            this.speciestxt.BorderRadius = 10;
            this.speciestxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.speciestxt.DefaultText = "";
            this.speciestxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.speciestxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.speciestxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.speciestxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.speciestxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.speciestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.speciestxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.speciestxt.Location = new System.Drawing.Point(469, 409);
            this.speciestxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.speciestxt.Name = "speciestxt";
            this.speciestxt.PasswordChar = '\0';
            this.speciestxt.PlaceholderText = "";
            this.speciestxt.SelectedText = "";
            this.speciestxt.Size = new System.Drawing.Size(191, 39);
            this.speciestxt.TabIndex = 86;
            this.speciestxt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // health
            // 
            this.health.BackColor = System.Drawing.Color.Transparent;
            this.health.BorderRadius = 10;
            this.health.Cursor = System.Windows.Forms.Cursors.Hand;
            this.health.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.health.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.health.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.health.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.health.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.health.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.health.ItemHeight = 30;
            this.health.Items.AddRange(new object[] {
            "Male",
            "Femal"});
            this.health.Location = new System.Drawing.Point(1075, 164);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(191, 36);
            this.health.TabIndex = 87;
            this.health.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // Arraival
            // 
            this.Arraival.Animated = true;
            this.Arraival.BorderRadius = 10;
            this.Arraival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Arraival.DefaultText = "";
            this.Arraival.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Arraival.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Arraival.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Arraival.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Arraival.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Arraival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Arraival.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Arraival.Location = new System.Drawing.Point(1075, 416);
            this.Arraival.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Arraival.Name = "Arraival";
            this.Arraival.PasswordChar = '\0';
            this.Arraival.PlaceholderText = "";
            this.Arraival.SelectedText = "";
            this.Arraival.Size = new System.Drawing.Size(191, 39);
            this.Arraival.TabIndex = 89;
            this.Arraival.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(832, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 90;
            this.label1.Text = "Arraival Daate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.Animated = true;
            this.YearOfBirth.BorderRadius = 10;
            this.YearOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YearOfBirth.DefaultText = "";
            this.YearOfBirth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.YearOfBirth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.YearOfBirth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.YearOfBirth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.YearOfBirth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearOfBirth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearOfBirth.Location = new System.Drawing.Point(1079, 545);
            this.YearOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.PasswordChar = '\0';
            this.YearOfBirth.PlaceholderText = "";
            this.YearOfBirth.SelectedText = "";
            this.YearOfBirth.Size = new System.Drawing.Size(191, 39);
            this.YearOfBirth.TabIndex = 91;
            this.YearOfBirth.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label4.Location = new System.Drawing.Point(854, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 92;
            this.label4.Text = "Year Of Birth:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ADD
            // 
            this.ADD.Animated = true;
            this.ADD.AutoRoundedCorners = true;
            this.ADD.BackColor = System.Drawing.Color.Transparent;
            this.ADD.BorderRadius = 20;
            this.ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ADD.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ADD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(207)))), ((int)(((byte)(218)))));
            this.ADD.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.ADD.ForeColor = System.Drawing.Color.Black;
            this.ADD.Location = new System.Drawing.Point(1170, 734);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(153, 43);
            this.ADD.TabIndex = 93;
            this.ADD.Text = "ADD";
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Adoptbtn
            // 
            this.Adoptbtn.Animated = true;
            this.Adoptbtn.AutoRoundedCorners = true;
            this.Adoptbtn.BackColor = System.Drawing.Color.Transparent;
            this.Adoptbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.Adoptbtn.BorderRadius = 20;
            this.Adoptbtn.BorderThickness = 2;
            this.Adoptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adoptbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Adoptbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Adoptbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Adoptbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Adoptbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Adoptbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Adoptbtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Adoptbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.Adoptbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.Adoptbtn.Location = new System.Drawing.Point(226, 734);
            this.Adoptbtn.Name = "Adoptbtn";
            this.Adoptbtn.Size = new System.Drawing.Size(153, 43);
            this.Adoptbtn.TabIndex = 94;
            this.Adoptbtn.Text = "Clear";
            this.Adoptbtn.Click += new System.EventHandler(this.Adoptbtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(93)))), ((int)(((byte)(143)))));
            this.label18.Location = new System.Drawing.Point(139, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(278, 38);
            this.label18.TabIndex = 95;
            this.label18.Text = "Add A NEW PET";
            // 
            // petgender
            // 
            this.petgender.BackColor = System.Drawing.Color.Transparent;
            this.petgender.BorderRadius = 10;
            this.petgender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.petgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.petgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.petgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petgender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.petgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.petgender.ItemHeight = 30;
            this.petgender.Items.AddRange(new object[] {
            "Male",
            "Femal"});
            this.petgender.Location = new System.Drawing.Point(474, 170);
            this.petgender.Name = "petgender";
            this.petgender.Size = new System.Drawing.Size(186, 36);
            this.petgender.TabIndex = 96;
            // 
            // petsetter
            // 
            this.petsetter.Animated = true;
            this.petsetter.BorderRadius = 10;
            this.petsetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.petsetter.DefaultText = "";
            this.petsetter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.petsetter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.petsetter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.petsetter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.petsetter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petsetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petsetter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.petsetter.Location = new System.Drawing.Point(1075, 286);
            this.petsetter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.petsetter.Name = "petsetter";
            this.petsetter.PasswordChar = '\0';
            this.petsetter.PlaceholderText = "";
            this.petsetter.SelectedText = "";
            this.petsetter.Size = new System.Drawing.Size(191, 39);
            this.petsetter.TabIndex = 97;
            // 
            // navBarPanel1
            // 
            this.navBarPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel1.Location = new System.Drawing.Point(0, 0);
            this.navBarPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.navBarPanel1.Name = "navBarPanel1";
            this.navBarPanel1.Size = new System.Drawing.Size(68, 830);
            this.navBarPanel1.TabIndex = 98;
            this.navBarPanel1.showHomeForm += new System.EventHandler(this.navBarPanel1_showHomeForm);
            this.navBarPanel1.showPetsForm += new System.EventHandler(this.navBarPanel1_showPetsForm);
            this.navBarPanel1.showMedicalCareForm += new System.EventHandler(this.navBarPanel1_showMedicalCareForm);
            this.navBarPanel1.showInvoiceForm += new System.EventHandler(this.navBarPanel1_showInvoiceForm);
            // 
            // AddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LittleSouls.Properties.Resources.الخلفية_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 830);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.navBarPanel1);
            this.Controls.Add(this.petsetter);
            this.Controls.Add(this.petgender);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Adoptbtn);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.YearOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Arraival);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.health);
            this.Controls.Add(this.speciestxt);
            this.Controls.Add(this.BreedCombo);
            this.Controls.Add(this.PetColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Name = "AddPet";
            this.Text = "Add Pet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddPet_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox BreedCombo;
        private Guna.UI2.WinForms.Guna2ComboBox PetColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox speciestxt;
        private Guna.UI2.WinForms.Guna2ComboBox health;
        private Guna.UI2.WinForms.Guna2TextBox Arraival;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox YearOfBirth;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton ADD;
        private Guna.UI2.WinForms.Guna2GradientButton Adoptbtn;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2ComboBox petgender;
        private Guna.UI2.WinForms.Guna2TextBox petsetter;
        private System.Windows.Forms.Label label11;
        private NavBarPanel navBarPanel1;
    }
}