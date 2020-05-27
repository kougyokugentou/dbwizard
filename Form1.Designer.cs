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
            this.exportAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitWithoutSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitsavesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDbID = new System.Windows.Forms.NumericUpDown();
            this.parentDbID = new System.Windows.Forms.NumericUpDown();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.foundStudents_comboBox = new System.Windows.Forms.ComboBox();
            this.lblFoundStudents = new System.Windows.Forms.Label();
            this.saveFileDialogReport = new System.Windows.Forms.SaveFileDialog();
            this.student_pictureBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.studentDbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentDbID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.parent_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(562, 104);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(113, 32);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(330, 104);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(117, 32);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // student_idLabel
            // 
            student_idLabel.AutoSize = true;
            student_idLabel.BackColor = System.Drawing.Color.Transparent;
            student_idLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            student_idLabel.Location = new System.Drawing.Point(88, 320);
            student_idLabel.Name = "student_idLabel";
            student_idLabel.Size = new System.Drawing.Size(114, 32);
            student_idLabel.TabIndex = 6;
            student_idLabel.Text = "Student ID:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.BackColor = System.Drawing.Color.Transparent;
            dOBLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dOBLabel.Location = new System.Drawing.Point(330, 189);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(61, 32);
            dOBLabel.TabIndex = 8;
            dOBLabel.Text = "DOB:";
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.BackColor = System.Drawing.Color.Transparent;
            programNameLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            programNameLabel.Location = new System.Drawing.Point(562, 189);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(95, 32);
            programNameLabel.TabIndex = 10;
            programNameLabel.Text = "Program:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(330, 392);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(90, 32);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.BackColor = System.Drawing.Color.Transparent;
            schoolLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schoolLabel.Location = new System.Drawing.Point(562, 286);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new System.Drawing.Size(77, 32);
            schoolLabel.TabIndex = 14;
            schoolLabel.Text = "School:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = System.Drawing.Color.Transparent;
            genderLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(329, 286);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(84, 32);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.BackColor = System.Drawing.Color.Transparent;
            gradeLevelLabel.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gradeLevelLabel.Location = new System.Drawing.Point(562, 392);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(122, 32);
            gradeLevelLabel.TabIndex = 18;
            gradeLevelLabel.Text = "Grade Level:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel1.Location = new System.Drawing.Point(10, 119);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(113, 32);
            lastNameLabel1.TabIndex = 0;
            lastNameLabel1.Text = "Last Name:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel1.Location = new System.Drawing.Point(10, 56);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(117, 32);
            firstNameLabel1.TabIndex = 2;
            firstNameLabel1.Text = "First Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            phoneNumberLabel.Location = new System.Drawing.Point(10, 183);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(149, 32);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.BackColor = System.Drawing.Color.Transparent;
            emailAddressLabel.Location = new System.Drawing.Point(10, 250);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(145, 32);
            emailAddressLabel.TabIndex = 6;
            emailAddressLabel.Text = "Email Address:";
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 3;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.topTableLayoutPanel.Controls.Add(this.mainMenuStrip, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.studentDbID, 1, 0);
            this.topTableLayoutPanel.Controls.Add(this.parentDbID, 2, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(1395, 35);
            this.topTableLayoutPanel.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.schoolsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1299, 35);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.saveStudentToolStripMenuItem,
            this.exportAllDataToolStripMenuItem,
            this.exitWithoutSavingToolStripMenuItem,
            this.exitsavesDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 31);
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
            // exportAllDataToolStripMenuItem
            // 
            this.exportAllDataToolStripMenuItem.Name = "exportAllDataToolStripMenuItem";
            this.exportAllDataToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.exportAllDataToolStripMenuItem.Text = "Export All Data";
            this.exportAllDataToolStripMenuItem.Click += new System.EventHandler(this.exportAllDataToolStripMenuItem_Click);
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
            // schoolsToolStripMenuItem
            // 
            this.schoolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolEditorToolStripMenuItem});
            this.schoolsToolStripMenuItem.Font = new System.Drawing.Font("Sitka Display", 10.875F);
            this.schoolsToolStripMenuItem.Name = "schoolsToolStripMenuItem";
            this.schoolsToolStripMenuItem.Size = new System.Drawing.Size(96, 31);
            this.schoolsToolStripMenuItem.Text = "Schools";
            // 
            // schoolEditorToolStripMenuItem
            // 
            this.schoolEditorToolStripMenuItem.Name = "schoolEditorToolStripMenuItem";
            this.schoolEditorToolStripMenuItem.Size = new System.Drawing.Size(235, 40);
            this.schoolEditorToolStripMenuItem.Text = "School Editor";
            this.schoolEditorToolStripMenuItem.Click += new System.EventHandler(this.schoolEditorToolStripMenuItem_Click);
            // 
            // studentDbID
            // 
            this.studentDbID.Font = new System.Drawing.Font("Sitka Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDbID.Location = new System.Drawing.Point(1302, 3);
            this.studentDbID.Name = "studentDbID";
            this.studentDbID.Size = new System.Drawing.Size(40, 30);
            this.studentDbID.TabIndex = 8;
            this.studentDbID.TabStop = false;
            this.studentDbID.Visible = false;
            // 
            // parentDbID
            // 
            this.parentDbID.Location = new System.Drawing.Point(1348, 3);
            this.parentDbID.Name = "parentDbID";
            this.parentDbID.Size = new System.Drawing.Size(44, 26);
            this.parentDbID.TabIndex = 29;
            this.parentDbID.TabStop = false;
            this.parentDbID.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(568, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(167, 35);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DBWizard.Models.Student);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(334, 141);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(177, 35);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // student_idTextBox
            // 
            this.student_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_id", true));
            this.student_idTextBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_idTextBox.Location = new System.Drawing.Point(93, 357);
            this.student_idTextBox.Name = "student_idTextBox";
            this.student_idTextBox.Size = new System.Drawing.Size(135, 35);
            this.student_idTextBox.TabIndex = 6;
            this.student_idTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.student_idTextBox_Validating);
            // 
            // dob_dateTimePicker
            // 
            this.dob_dateTimePicker.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_dateTimePicker.Location = new System.Drawing.Point(334, 228);
            this.dob_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob_dateTimePicker.Name = "dob_dateTimePicker";
            this.dob_dateTimePicker.Size = new System.Drawing.Size(135, 35);
            this.dob_dateTimePicker.TabIndex = 2;
            this.dob_dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dob_dateTimePicker_Validating);
            // 
            // programComboBox
            // 
            this.programComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programComboBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(568, 228);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(177, 40);
            this.programComboBox.TabIndex = 3;
            this.programComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(335, 436);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(167, 66);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "School.name", true));
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(566, 330);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(177, 40);
            this.schoolComboBox.TabIndex = 5;
            this.schoolComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(334, 330);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 40);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // gradeLevelComboBox
            // 
            this.gradeLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "GradeLevel", true));
            this.gradeLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeLevelComboBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gradeLevelComboBox.Location = new System.Drawing.Point(568, 433);
            this.gradeLevelComboBox.Name = "gradeLevelComboBox";
            this.gradeLevelComboBox.Size = new System.Drawing.Size(121, 40);
            this.gradeLevelComboBox.TabIndex = 8;
            this.gradeLevelComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // save_button
            // 
            this.save_button.AutoSize = true;
            this.save_button.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(137, 570);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(133, 60);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // parent_groupBox
            // 
            this.parent_groupBox.AutoSize = true;
            this.parent_groupBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.parent_groupBox.Controls.Add(emailAddressLabel);
            this.parent_groupBox.Controls.Add(this.emailAddressTextBox);
            this.parent_groupBox.Controls.Add(phoneNumberLabel);
            this.parent_groupBox.Controls.Add(this.phoneNumberNumericUpDown);
            this.parent_groupBox.Controls.Add(firstNameLabel1);
            this.parent_groupBox.Controls.Add(this.parent_firstNameTextBox);
            this.parent_groupBox.Controls.Add(lastNameLabel1);
            this.parent_groupBox.Controls.Add(this.parent_lastNameTextBox);
            this.parent_groupBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_groupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.parent_groupBox.Location = new System.Drawing.Point(788, 320);
            this.parent_groupBox.Name = "parent_groupBox";
            this.parent_groupBox.Size = new System.Drawing.Size(419, 348);
            this.parent_groupBox.TabIndex = 9;
            this.parent_groupBox.TabStop = false;
            this.parent_groupBox.Text = "Parent Information";
            this.parent_groupBox.Enter += new System.EventHandler(this.parent_groupBox_Enter);
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(188, 250);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(172, 35);
            this.emailAddressTextBox.TabIndex = 3;
            this.toolTips.SetToolTip(this.emailAddressTextBox, "Enter a valid email address with @");
            this.emailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailAddressTextBox_Validating);
            // 
            // phoneNumberNumericUpDown
            // 
            this.phoneNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Parent.PhoneNumber", true));
            this.phoneNumberNumericUpDown.Location = new System.Drawing.Point(188, 182);
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
            this.phoneNumberNumericUpDown.Size = new System.Drawing.Size(172, 35);
            this.phoneNumberNumericUpDown.TabIndex = 2;
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
            this.parent_firstNameTextBox.Location = new System.Drawing.Point(187, 56);
            this.parent_firstNameTextBox.Name = "parent_firstNameTextBox";
            this.parent_firstNameTextBox.Size = new System.Drawing.Size(173, 35);
            this.parent_firstNameTextBox.TabIndex = 0;
            this.parent_firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // parent_lastNameTextBox
            // 
            this.parent_lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.LastName", true));
            this.parent_lastNameTextBox.Location = new System.Drawing.Point(187, 117);
            this.parent_lastNameTextBox.Name = "parent_lastNameTextBox";
            this.parent_lastNameTextBox.Size = new System.Drawing.Size(173, 35);
            this.parent_lastNameTextBox.TabIndex = 1;
            this.parent_lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // clear_button
            // 
            this.clear_button.AutoSize = true;
            this.clear_button.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(347, 570);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(142, 60);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "Clear form";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.AutoSize = true;
            this.delete_button.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(566, 570);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(130, 60);
            this.delete_button.TabIndex = 12;
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
            this.lblSearch.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(806, 104);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(275, 32);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search Student by Last Name:";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textBox.Location = new System.Drawing.Point(809, 141);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(284, 35);
            this.search_textBox.TabIndex = 13;
            this.toolTips.SetToolTip(this.search_textBox, "Type last name of student and hit enter");
            this.search_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_textBox_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // foundStudents_comboBox
            // 
            this.foundStudents_comboBox.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundStudents_comboBox.FormattingEnabled = true;
            this.foundStudents_comboBox.Location = new System.Drawing.Point(811, 228);
            this.foundStudents_comboBox.Name = "foundStudents_comboBox";
            this.foundStudents_comboBox.Size = new System.Drawing.Size(284, 40);
            this.foundStudents_comboBox.TabIndex = 14;
            this.foundStudents_comboBox.SelectionChangeCommitted += new System.EventHandler(this.foundStudents_comboBox_SelectionChangeCommitted);
            this.foundStudents_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foundStudents_comboBox_KeyDown);
            // 
            // lblFoundStudents
            // 
            this.lblFoundStudents.AutoSize = true;
            this.lblFoundStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblFoundStudents.Font = new System.Drawing.Font("Sitka Display", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundStudents.Location = new System.Drawing.Point(806, 189);
            this.lblFoundStudents.Name = "lblFoundStudents";
            this.lblFoundStudents.Size = new System.Drawing.Size(157, 32);
            this.lblFoundStudents.TabIndex = 28;
            this.lblFoundStudents.Text = "Found Students:";
            // 
            // saveFileDialogReport
            // 
            this.saveFileDialogReport.DefaultExt = "CSV";
            this.saveFileDialogReport.Filter = "CSV Files|*.csv";
            this.saveFileDialogReport.Title = "Save Report";
            // 
            // student_pictureBox
            // 
            this.student_pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.student_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("student_pictureBox.Image")));
            this.student_pictureBox.Location = new System.Drawing.Point(93, 103);
            this.student_pictureBox.Name = "student_pictureBox";
            this.student_pictureBox.Size = new System.Drawing.Size(200, 198);
            this.student_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.student_pictureBox.TabIndex = 1;
            this.student_pictureBox.TabStop = false;
            this.student_pictureBox.Tag = "DefaultImage";
            this.student_pictureBox.DoubleClick += new System.EventHandler(this.student_pictureBox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 840);
            this.Controls.Add(this.lblFoundStudents);
            this.Controls.Add(this.foundStudents_comboBox);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Controls.Add(student_idLabel);
            this.Controls.Add(this.student_pictureBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.student_idTextBox);
            this.Controls.Add(this.parent_groupBox);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.dob_dateTimePicker);
            this.Controls.Add(gradeLevelLabel);
            this.Controls.Add(programNameLabel);
            this.Controls.Add(this.gradeLevelComboBox);
            this.Controls.Add(this.programComboBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(schoolLabel);
            this.Controls.Add(this.schoolComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1344, 826);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KentYouthDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentDbID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.parent_groupBox.ResumeLayout(false);
            this.parent_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_pictureBox)).EndInit();
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
        private System.Windows.Forms.Label lblFoundStudents;
        private System.Windows.Forms.ComboBox foundStudents_comboBox;
        private System.Windows.Forms.NumericUpDown studentDbID;
        private System.Windows.Forms.ToolStripMenuItem exitWithoutSavingToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown parentDbID;
        private System.Windows.Forms.ToolStripMenuItem exportAllDataToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogReport;
        private System.Windows.Forms.ToolStripMenuItem schoolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolEditorToolStripMenuItem;
    }
}

