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
            this.parentDbID = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.parentDbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(472, 6);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(93, 26);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(240, 6);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(97, 26);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // student_idLabel
            // 
            student_idLabel.AutoSize = true;
            student_idLabel.BackColor = System.Drawing.Color.Transparent;
            student_idLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            student_idLabel.Location = new System.Drawing.Point(37, 182);
            student_idLabel.Name = "student_idLabel";
            student_idLabel.Size = new System.Drawing.Size(93, 26);
            student_idLabel.TabIndex = 6;
            student_idLabel.Text = "Student ID:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.BackColor = System.Drawing.Color.Transparent;
            dOBLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.Location = new System.Drawing.Point(240, 78);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(49, 26);
            dOBLabel.TabIndex = 8;
            dOBLabel.Text = "DOB:";
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.BackColor = System.Drawing.Color.Transparent;
            programNameLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            programNameLabel.Location = new System.Drawing.Point(472, 78);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(79, 26);
            programNameLabel.TabIndex = 10;
            programNameLabel.Text = "Program:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(240, 220);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(74, 26);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.BackColor = System.Drawing.Color.Transparent;
            schoolLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schoolLabel.Location = new System.Drawing.Point(472, 150);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new System.Drawing.Size(64, 26);
            schoolLabel.TabIndex = 14;
            schoolLabel.Text = "School:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.Transparent;
            genderLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(240, 150);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(69, 26);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.BackColor = System.Drawing.Color.Transparent;
            gradeLevelLabel.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradeLevelLabel.Location = new System.Drawing.Point(472, 220);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(101, 26);
            gradeLevelLabel.TabIndex = 18;
            gradeLevelLabel.Text = "Grade Level:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel1.Location = new System.Drawing.Point(10, 94);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(93, 26);
            lastNameLabel1.TabIndex = 0;
            lastNameLabel1.Text = "Last Name:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel1.Location = new System.Drawing.Point(10, 50);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(97, 26);
            firstNameLabel1.TabIndex = 2;
            firstNameLabel1.Text = "First Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNumberLabel.Location = new System.Drawing.Point(10, 139);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(124, 26);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.BackColor = System.Drawing.Color.Transparent;
            emailAddressLabel.Location = new System.Drawing.Point(10, 189);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(119, 26);
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
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(1068, 35);
            this.topTableLayoutPanel.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1068, 33);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.newStudentToolStripMenuItem.Text = "&New Student";
            this.newStudentToolStripMenuItem.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // saveStudentToolStripMenuItem
            // 
            this.saveStudentToolStripMenuItem.Name = "saveStudentToolStripMenuItem";
            this.saveStudentToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.saveStudentToolStripMenuItem.Text = "&Save Student";
            this.saveStudentToolStripMenuItem.Click += new System.EventHandler(this.save_button_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentBySchoolToolStripMenuItem,
            this.studentsByProgramToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // studentBySchoolToolStripMenuItem
            // 
            this.studentBySchoolToolStripMenuItem.Name = "studentBySchoolToolStripMenuItem";
            this.studentBySchoolToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.studentBySchoolToolStripMenuItem.Text = "Students by school";
            // 
            // studentsByProgramToolStripMenuItem
            // 
            this.studentsByProgramToolStripMenuItem.Name = "studentsByProgramToolStripMenuItem";
            this.studentsByProgramToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.studentsByProgramToolStripMenuItem.Text = "Students by program";
            // 
            // exitWithoutSavingToolStripMenuItem
            // 
            this.exitWithoutSavingToolStripMenuItem.Name = "exitWithoutSavingToolStripMenuItem";
            this.exitWithoutSavingToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.exitWithoutSavingToolStripMenuItem.Text = "Exit without saving";
            this.exitWithoutSavingToolStripMenuItem.Click += new System.EventHandler(this.exitWithoutSavingToolStripMenuItem_Click);
            // 
            // exitsavesDataToolStripMenuItem
            // 
            this.exitsavesDataToolStripMenuItem.Name = "exitsavesDataToolStripMenuItem";
            this.exitsavesDataToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.exitsavesDataToolStripMenuItem.Text = "E&xit (saves data)";
            this.exitsavesDataToolStripMenuItem.Click += new System.EventHandler(this.exitsavesDataToolStripMenuItem_Click);
            // 
            // student_pictureBox
            // 
            this.student_pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.student_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("student_pictureBox.Image")));
            this.student_pictureBox.Location = new System.Drawing.Point(41, 22);
            this.student_pictureBox.Name = "student_pictureBox";
            this.student_pictureBox.Size = new System.Drawing.Size(156, 156);
            this.student_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.student_pictureBox.TabIndex = 1;
            this.student_pictureBox.TabStop = false;
            this.student_pictureBox.Tag = "DefaultImage";
            this.student_pictureBox.DoubleClick += new System.EventHandler(this.student_pictureBox_DoubleClick);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(476, 37);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(167, 30);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(243, 37);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(177, 30);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // student_idTextBox
            // 
            this.student_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_id", true));
            this.student_idTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_idTextBox.Location = new System.Drawing.Point(41, 215);
            this.student_idTextBox.Name = "student_idTextBox";
            this.student_idTextBox.Size = new System.Drawing.Size(135, 30);
            this.student_idTextBox.TabIndex = 7;
            this.student_idTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.student_idTextBox_Validating);
            // 
            // dob_dateTimePicker
            // 
            this.dob_dateTimePicker.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_dateTimePicker.Location = new System.Drawing.Point(244, 109);
            this.dob_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob_dateTimePicker.Name = "dob_dateTimePicker";
            this.dob_dateTimePicker.Size = new System.Drawing.Size(135, 30);
            this.dob_dateTimePicker.TabIndex = 9;
            this.dob_dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dob_dateTimePicker_Validating);
            // 
            // programComboBox
            // 
            this.programComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programComboBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(476, 105);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(177, 34);
            this.programComboBox.TabIndex = 11;
            this.programComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(244, 251);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(167, 66);
            this.addressTextBox.TabIndex = 13;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "School.name", true));
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(476, 180);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(177, 34);
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
            this.genderComboBox.Location = new System.Drawing.Point(244, 180);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 34);
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
            this.gradeLevelComboBox.Location = new System.Drawing.Point(476, 251);
            this.gradeLevelComboBox.Name = "gradeLevelComboBox";
            this.gradeLevelComboBox.Size = new System.Drawing.Size(121, 34);
            this.gradeLevelComboBox.TabIndex = 19;
            this.gradeLevelComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(79, 366);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(104, 54);
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
            this.parent_groupBox.Location = new System.Drawing.Point(688, 180);
            this.parent_groupBox.Name = "parent_groupBox";
            this.parent_groupBox.Size = new System.Drawing.Size(348, 249);
            this.parent_groupBox.TabIndex = 21;
            this.parent_groupBox.TabStop = false;
            this.parent_groupBox.Text = "Parent Information";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(140, 186);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(172, 30);
            this.emailAddressTextBox.TabIndex = 7;
            this.toolTips.SetToolTip(this.emailAddressTextBox, "Enter a valid email address with @");
            this.emailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailAddressTextBox_Validating);
            // 
            // phoneNumberNumericUpDown
            // 
            this.phoneNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Parent.PhoneNumber", true));
            this.phoneNumberNumericUpDown.Location = new System.Drawing.Point(139, 139);
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
            this.phoneNumberNumericUpDown.Size = new System.Drawing.Size(172, 30);
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
            this.parent_firstNameTextBox.Location = new System.Drawing.Point(139, 50);
            this.parent_firstNameTextBox.Name = "parent_firstNameTextBox";
            this.parent_firstNameTextBox.Size = new System.Drawing.Size(173, 30);
            this.parent_firstNameTextBox.TabIndex = 3;
            this.parent_firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // parent_lastNameTextBox
            // 
            this.parent_lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.LastName", true));
            this.parent_lastNameTextBox.Location = new System.Drawing.Point(139, 94);
            this.parent_lastNameTextBox.Name = "parent_lastNameTextBox";
            this.parent_lastNameTextBox.Size = new System.Drawing.Size(173, 30);
            this.parent_lastNameTextBox.TabIndex = 1;
            this.parent_lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(243, 366);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(116, 54);
            this.clear_button.TabIndex = 22;
            this.clear_button.Text = "Clear form";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(420, 366);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(104, 54);
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
            this.lblSearch.Location = new System.Drawing.Point(710, 4);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(226, 26);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search Student by Last Name:";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.Location = new System.Drawing.Point(714, 45);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(284, 30);
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
            this.btnChaosMonkey.Location = new System.Drawing.Point(559, 366);
            this.btnChaosMonkey.Name = "btnChaosMonkey";
            this.btnChaosMonkey.Size = new System.Drawing.Size(106, 54);
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
            this.foundStudents_comboBox.Location = new System.Drawing.Point(714, 126);
            this.foundStudents_comboBox.Name = "foundStudents_comboBox";
            this.foundStudents_comboBox.Size = new System.Drawing.Size(284, 34);
            this.foundStudents_comboBox.TabIndex = 27;
            this.foundStudents_comboBox.SelectionChangeCommitted += new System.EventHandler(this.foundStudents_comboBox_SelectionChangeCommitted);
            this.foundStudents_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foundStudents_comboBox_KeyDown);
            // 
            // lblFoundStudents
            // 
            this.lblFoundStudents.AutoSize = true;
            this.lblFoundStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblFoundStudents.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundStudents.Location = new System.Drawing.Point(710, 87);
            this.lblFoundStudents.Name = "lblFoundStudents";
            this.lblFoundStudents.Size = new System.Drawing.Size(128, 26);
            this.lblFoundStudents.TabIndex = 28;
            this.lblFoundStudents.Text = "Found Students:";
            // 
            // studentDbID
            // 
            this.studentDbID.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDbID.Location = new System.Drawing.Point(5, 32);
            this.studentDbID.Name = "studentDbID";
            this.studentDbID.Size = new System.Drawing.Size(47, 30);
            this.studentDbID.TabIndex = 8;
            this.studentDbID.TabStop = false;
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
            this.panel1.Controls.Add(this.parentDbID);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 553);
            this.panel1.TabIndex = 29;
            // 
            // parentDbID
            // 
            this.parentDbID.Location = new System.Drawing.Point(942, -2);
            this.parentDbID.Name = "parentDbID";
            this.parentDbID.Size = new System.Drawing.Size(47, 26);
            this.parentDbID.TabIndex = 29;
            this.parentDbID.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DBWizard.Models.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studentDbID);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1071, 656);
            this.Name = "Form1";
            this.Text = "KentYouthDB";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.parentDbID)).EndInit();
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
        private System.Windows.Forms.NumericUpDown parentDbID;
    }
}

