namespace DBWizard
{
    partial class Form1
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label student_idLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label programNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label schoolLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label gradeLevelLabel;
            System.Windows.Forms.Label lastNameLabel1;
            System.Windows.Forms.Label firstNameLabel1;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label emailAddressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentBySchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsByProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWithoutSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitsavesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.student_pictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.student_idTextBox = new System.Windows.Forms.TextBox();
            this.dob_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.programComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.schoolComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.gradeLevelComboBox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.parent_groupBox = new System.Windows.Forms.GroupBox();
            this.emailAddressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.parent_firstNameTextBox = new System.Windows.Forms.TextBox();
            this.parent_lastNameTextBox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.pic_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblSearch = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnChaosMonkey = new System.Windows.Forms.Button();
            this.foundStudents_comboBox = new System.Windows.Forms.ComboBox();
            this.lblFoundStudents = new System.Windows.Forms.Label();
            this.studentDbID = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            student_idLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            programNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            schoolLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            gradeLevelLabel = new System.Windows.Forms.Label();
            lastNameLabel1 = new System.Windows.Forms.Label();
            firstNameLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            emailAddressLabel = new System.Windows.Forms.Label();
            this.topTableLayoutPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pictureBox)).BeginInit();
            this.parent_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(629, 7);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(122, 35);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(320, 7);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(126, 35);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // student_idLabel
            // 
            student_idLabel.AutoSize = true;
            student_idLabel.BackColor = System.Drawing.Color.Transparent;
            student_idLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            student_idLabel.Location = new System.Drawing.Point(49, 228);
            student_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            student_idLabel.Name = "student_idLabel";
            student_idLabel.Size = new System.Drawing.Size(123, 35);
            student_idLabel.TabIndex = 6;
            student_idLabel.Text = "Student ID:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.BackColor = System.Drawing.Color.Transparent;
            dOBLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.Location = new System.Drawing.Point(320, 98);
            dOBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(65, 35);
            dOBLabel.TabIndex = 8;
            dOBLabel.Text = "DOB:";
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.BackColor = System.Drawing.Color.Transparent;
            programNameLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            programNameLabel.Location = new System.Drawing.Point(629, 98);
            programNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(104, 35);
            programNameLabel.TabIndex = 10;
            programNameLabel.Text = "Program:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(320, 275);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(96, 35);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.BackColor = System.Drawing.Color.Transparent;
            schoolLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schoolLabel.Location = new System.Drawing.Point(629, 187);
            schoolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new System.Drawing.Size(84, 35);
            schoolLabel.TabIndex = 14;
            schoolLabel.Text = "School:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.Transparent;
            genderLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(320, 187);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(91, 35);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.BackColor = System.Drawing.Color.Transparent;
            gradeLevelLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradeLevelLabel.Location = new System.Drawing.Point(629, 275);
            gradeLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(134, 35);
            gradeLevelLabel.TabIndex = 18;
            gradeLevelLabel.Text = "Grade Level:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel1.Location = new System.Drawing.Point(13, 117);
            lastNameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(122, 35);
            lastNameLabel1.TabIndex = 0;
            lastNameLabel1.Text = "Last Name:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel1.Location = new System.Drawing.Point(13, 63);
            firstNameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(126, 35);
            firstNameLabel1.TabIndex = 2;
            firstNameLabel1.Text = "First Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNumberLabel.Location = new System.Drawing.Point(13, 174);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(164, 35);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.BackColor = System.Drawing.Color.Transparent;
            emailAddressLabel.Location = new System.Drawing.Point(13, 236);
            emailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(157, 35);
            emailAddressLabel.TabIndex = 6;
            emailAddressLabel.Text = "Email Address:";
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 1;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Controls.Add(this.mainMenuStrip, 0, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(1424, 44);
            this.topTableLayoutPanel.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(1424, 40);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.saveStudentToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitWithoutSavingToolStripMenuItem,
            this.exitsavesDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.newStudentToolStripMenuItem.Text = "&New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.newStudentToolStripMenuItem_Click);
            // 
            // saveStudentToolStripMenuItem
            // 
            this.saveStudentToolStripMenuItem.Name = "saveStudentToolStripMenuItem";
            this.saveStudentToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.saveStudentToolStripMenuItem.Text = "&Save Student";
            this.saveStudentToolStripMenuItem.Click += new System.EventHandler(this.saveStudentToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentBySchoolToolStripMenuItem,
            this.studentsByProgramToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // studentBySchoolToolStripMenuItem
            // 
            this.studentBySchoolToolStripMenuItem.Name = "studentBySchoolToolStripMenuItem";
            this.studentBySchoolToolStripMenuItem.Size = new System.Drawing.Size(373, 44);
            this.studentBySchoolToolStripMenuItem.Text = "Students by school";
            // 
            // studentsByProgramToolStripMenuItem
            // 
            this.studentsByProgramToolStripMenuItem.Name = "studentsByProgramToolStripMenuItem";
            this.studentsByProgramToolStripMenuItem.Size = new System.Drawing.Size(373, 44);
            this.studentsByProgramToolStripMenuItem.Text = "Students by program";
            // 
            // exitWithoutSavingToolStripMenuItem
            // 
            this.exitWithoutSavingToolStripMenuItem.Name = "exitWithoutSavingToolStripMenuItem";
            this.exitWithoutSavingToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.exitWithoutSavingToolStripMenuItem.Text = "Exit without saving";
            this.exitWithoutSavingToolStripMenuItem.Click += new System.EventHandler(this.exitWithoutSavingToolStripMenuItem_Click);
            // 
            // exitsavesDataToolStripMenuItem
            // 
            this.exitsavesDataToolStripMenuItem.Name = "exitsavesDataToolStripMenuItem";
            this.exitsavesDataToolStripMenuItem.Size = new System.Drawing.Size(349, 44);
            this.exitsavesDataToolStripMenuItem.Text = "E&xit (saves data)";
            this.exitsavesDataToolStripMenuItem.Click += new System.EventHandler(this.exitsavesDataToolStripMenuItem_Click);
            // 
            // student_pictureBox
            // 
            this.student_pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.student_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("student_pictureBox.Image")));
            this.student_pictureBox.Location = new System.Drawing.Point(55, 27);
            this.student_pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.student_pictureBox.Name = "student_pictureBox";
            this.student_pictureBox.Size = new System.Drawing.Size(208, 195);
            this.student_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.student_pictureBox.TabIndex = 1;
            this.student_pictureBox.TabStop = false;
            this.student_pictureBox.Tag = "DefaultImage";
            this.student_pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(635, 46);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(221, 38);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(324, 46);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(235, 38);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // student_idTextBox
            // 
            this.student_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_id", true));
            this.student_idTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_idTextBox.Location = new System.Drawing.Point(55, 269);
            this.student_idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.student_idTextBox.Name = "student_idTextBox";
            this.student_idTextBox.Size = new System.Drawing.Size(179, 38);
            this.student_idTextBox.TabIndex = 7;
            this.student_idTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.student_idTextBox_Validating);
            // 
            // dob_dateTimePicker
            // 
            this.dob_dateTimePicker.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_dateTimePicker.Location = new System.Drawing.Point(326, 136);
            this.dob_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dob_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob_dateTimePicker.Name = "dob_dateTimePicker";
            this.dob_dateTimePicker.Size = new System.Drawing.Size(179, 38);
            this.dob_dateTimePicker.TabIndex = 9;
            this.dob_dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dob_dateTimePicker_Validating);
            // 
            // programComboBox
            // 
            this.programComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programComboBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(635, 131);
            this.programComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(235, 43);
            this.programComboBox.TabIndex = 11;
            this.programComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(326, 314);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(221, 81);
            this.addressTextBox.TabIndex = 13;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "School.name", true));
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(635, 225);
            this.schoolComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(235, 43);
            this.schoolComboBox.TabIndex = 15;
            this.schoolComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(326, 225);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(160, 43);
            this.genderComboBox.TabIndex = 17;
            this.genderComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // gradeLevelComboBox
            // 
            this.gradeLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "GradeLevel", true));
            this.gradeLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeLevelComboBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLevelComboBox.FormattingEnabled = true;
            this.gradeLevelComboBox.Items.AddRange(new object[] {
            "K",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.gradeLevelComboBox.Location = new System.Drawing.Point(635, 314);
            this.gradeLevelComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.gradeLevelComboBox.Name = "gradeLevelComboBox";
            this.gradeLevelComboBox.Size = new System.Drawing.Size(160, 43);
            this.gradeLevelComboBox.TabIndex = 19;
            this.gradeLevelComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(105, 457);
            this.save_button.Margin = new System.Windows.Forms.Padding(4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(139, 68);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // parent_groupBox
            // 
            this.parent_groupBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.parent_groupBox.Controls.Add(emailAddressLabel);
            this.parent_groupBox.Controls.Add(this.emailAddressTextBox);
            this.parent_groupBox.Controls.Add(phoneNumberLabel);
            this.parent_groupBox.Controls.Add(this.phoneNumberNumericUpDown);
            this.parent_groupBox.Controls.Add(firstNameLabel1);
            this.parent_groupBox.Controls.Add(this.parent_firstNameTextBox);
            this.parent_groupBox.Controls.Add(lastNameLabel1);
            this.parent_groupBox.Controls.Add(this.parent_lastNameTextBox);
            this.parent_groupBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parent_groupBox.Location = new System.Drawing.Point(917, 225);
            this.parent_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.parent_groupBox.Name = "parent_groupBox";
            this.parent_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.parent_groupBox.Size = new System.Drawing.Size(464, 311);
            this.parent_groupBox.TabIndex = 21;
            this.parent_groupBox.TabStop = false;
            this.parent_groupBox.Text = "Parent Information";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(186, 232);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(228, 38);
            this.emailAddressTextBox.TabIndex = 7;
            this.toolTips.SetToolTip(this.emailAddressTextBox, "Enter a valid email address with @");
            this.emailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailAddressTextBox_Validating);
            // 
            // phoneNumberNumericUpDown
            // 
            this.phoneNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Parent.PhoneNumber", true));
            this.phoneNumberNumericUpDown.Location = new System.Drawing.Point(185, 174);
            this.phoneNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.phoneNumberNumericUpDown.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.phoneNumberNumericUpDown.Name = "phoneNumberNumericUpDown";
            this.phoneNumberNumericUpDown.Size = new System.Drawing.Size(229, 38);
            this.phoneNumberNumericUpDown.TabIndex = 5;
            this.toolTips.SetToolTip(this.phoneNumberNumericUpDown, "Enter 9 digit phone number with no symbols.");
            this.phoneNumberNumericUpDown.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.phoneNumberNumericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.phoneNumberNumericUpDown_Validating);
            // 
            // parent_firstNameTextBox
            // 
            this.parent_firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.FirstName", true));
            this.parent_firstNameTextBox.Location = new System.Drawing.Point(185, 63);
            this.parent_firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.parent_firstNameTextBox.Name = "parent_firstNameTextBox";
            this.parent_firstNameTextBox.Size = new System.Drawing.Size(229, 38);
            this.parent_firstNameTextBox.TabIndex = 3;
            this.parent_firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // parent_lastNameTextBox
            // 
            this.parent_lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.LastName", true));
            this.parent_lastNameTextBox.Location = new System.Drawing.Point(185, 117);
            this.parent_lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.parent_lastNameTextBox.Name = "parent_lastNameTextBox";
            this.parent_lastNameTextBox.Size = new System.Drawing.Size(229, 38);
            this.parent_lastNameTextBox.TabIndex = 1;
            this.parent_lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(324, 457);
            this.clear_button.Margin = new System.Windows.Forms.Padding(4);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(155, 68);
            this.clear_button.TabIndex = 22;
            this.clear_button.Text = "Clear form";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(560, 457);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(139, 68);
            this.delete_button.TabIndex = 23;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // pic_openFileDialog
            // 
            this.pic_openFileDialog.DefaultExt = "*.png";
            this.pic_openFileDialog.FileName = "pic_openFileDialog";
            this.pic_openFileDialog.Filter = "Photos|*.png";
            this.pic_openFileDialog.Title = "Upload student photo";
            this.pic_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pic_openFileDialog_FileOk);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(946, 5);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(300, 35);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search Student by Last Name:";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.Location = new System.Drawing.Point(952, 56);
            this.search_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(377, 38);
            this.search_textBox.TabIndex = 25;
            this.toolTips.SetToolTip(this.search_textBox, "Type last name of student and hit enter");
            this.search_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_textBox_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnChaosMonkey
            // 
            this.btnChaosMonkey.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChaosMonkey.Location = new System.Drawing.Point(745, 422);
            this.btnChaosMonkey.Margin = new System.Windows.Forms.Padding(4);
            this.btnChaosMonkey.Name = "btnChaosMonkey";
            this.btnChaosMonkey.Size = new System.Drawing.Size(141, 68);
            this.btnChaosMonkey.TabIndex = 26;
            this.btnChaosMonkey.Text = "CHAOS";
            this.btnChaosMonkey.UseVisualStyleBackColor = true;
            this.btnChaosMonkey.Visible = false;
            this.btnChaosMonkey.Click += new System.EventHandler(this.btnChaosMonkey_Click);
            // 
            // foundStudents_comboBox
            // 
            this.foundStudents_comboBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundStudents_comboBox.FormattingEnabled = true;
            this.foundStudents_comboBox.Location = new System.Drawing.Point(952, 157);
            this.foundStudents_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.foundStudents_comboBox.Name = "foundStudents_comboBox";
            this.foundStudents_comboBox.Size = new System.Drawing.Size(377, 43);
            this.foundStudents_comboBox.TabIndex = 27;
            this.foundStudents_comboBox.SelectionChangeCommitted += new System.EventHandler(this.foundStudents_comboBox_SelectionChangeCommitted);
            this.foundStudents_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foundStudents_comboBox_KeyDown);
            // 
            // lblFoundStudents
            // 
            this.lblFoundStudents.AutoSize = true;
            this.lblFoundStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblFoundStudents.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundStudents.Location = new System.Drawing.Point(946, 109);
            this.lblFoundStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoundStudents.Name = "lblFoundStudents";
            this.lblFoundStudents.Size = new System.Drawing.Size(169, 35);
            this.lblFoundStudents.TabIndex = 28;
            this.lblFoundStudents.Text = "Found Students:";
            // 
            // studentDbID
            // 
            this.studentDbID.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDbID.Location = new System.Drawing.Point(1244, 40);
            this.studentDbID.Margin = new System.Windows.Forms.Padding(4);
            this.studentDbID.Name = "studentDbID";
            this.studentDbID.Size = new System.Drawing.Size(63, 38);
            this.studentDbID.TabIndex = 8;
            this.studentDbID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblFoundStudents);
            this.panel1.Controls.Add(this.foundStudents_comboBox);
            this.panel1.Controls.Add(student_idLabel);
            this.panel1.Controls.Add(this.btnChaosMonkey);
            this.panel1.Controls.Add(this.search_textBox);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.parent_groupBox);
            this.panel1.Controls.Add(this.save_button);
            this.panel1.Controls.Add(gradeLevelLabel);
            this.panel1.Controls.Add(this.gradeLevelComboBox);
            this.panel1.Controls.Add(genderLabel);
            this.panel1.Controls.Add(this.genderComboBox);
            this.panel1.Controls.Add(schoolLabel);
            this.panel1.Controls.Add(this.schoolComboBox);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.programComboBox);
            this.panel1.Controls.Add(programNameLabel);
            this.panel1.Controls.Add(this.dob_dateTimePicker);
            this.panel1.Controls.Add(dOBLabel);
            this.panel1.Controls.Add(this.student_idTextBox);
            this.panel1.Controls.Add(firstNameLabel);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(lastNameLabel);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.student_pictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 691);
            this.panel1.TabIndex = 29;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DBWizard.Models.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentDbID);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1421, 806);
            this.Name = "Form1";
            this.Text = "KentYouthDB";
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pictureBox)).EndInit();
            this.parent_groupBox.ResumeLayout(false);
            this.parent_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.PictureBox student_pictureBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox student_idTextBox;
        private System.Windows.Forms.DateTimePicker dob_dateTimePicker;
        private System.Windows.Forms.ComboBox programComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox schoolComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox gradeLevelComboBox;
        private System.Windows.Forms.ToolStripMenuItem newStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentBySchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsByProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitsavesDataToolStripMenuItem;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox parent_groupBox;
        private System.Windows.Forms.TextBox emailAddressTextBox;
        private System.Windows.Forms.NumericUpDown phoneNumberNumericUpDown;
        private System.Windows.Forms.TextBox parent_firstNameTextBox;
        private System.Windows.Forms.TextBox parent_lastNameTextBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.OpenFileDialog pic_openFileDialog;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Button btnChaosMonkey;
        private System.Windows.Forms.Label lblFoundStudents;
        private System.Windows.Forms.ComboBox foundStudents_comboBox;
        private System.Windows.Forms.NumericUpDown studentDbID;
        private System.Windows.Forms.ToolStripMenuItem exitWithoutSavingToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

