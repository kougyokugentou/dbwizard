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
            this.exitsavesDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).BeginInit();
            this.studentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_pictureBox)).BeginInit();
            this.parent_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(244, 48);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(121, 25);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(507, 48);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(122, 25);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // student_idLabel
            // 
            student_idLabel.AutoSize = true;
            student_idLabel.Location = new System.Drawing.Point(16, 250);
            student_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            student_idLabel.Name = "student_idLabel";
            student_idLabel.Size = new System.Drawing.Size(112, 25);
            student_idLabel.TabIndex = 6;
            student_idLabel.Text = "student id:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(13, 332);
            dOBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(63, 25);
            dOBLabel.TabIndex = 8;
            dOBLabel.Text = "DOB:";
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.Location = new System.Drawing.Point(507, 135);
            programNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(99, 25);
            programNameLabel.TabIndex = 10;
            programNameLabel.Text = "Program:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(247, 221);
            addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(95, 25);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "address:";
            // 
            // schoolLabel
            // 
            schoolLabel.AutoSize = true;
            schoolLabel.Location = new System.Drawing.Point(507, 221);
            schoolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            schoolLabel.Name = "schoolLabel";
            schoolLabel.Size = new System.Drawing.Size(84, 25);
            schoolLabel.TabIndex = 14;
            schoolLabel.Text = "School:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(247, 135);
            genderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(89, 25);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // gradeLevelLabel
            // 
            gradeLevelLabel.AutoSize = true;
            gradeLevelLabel.Location = new System.Drawing.Point(520, 328);
            gradeLevelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gradeLevelLabel.Name = "gradeLevelLabel";
            gradeLevelLabel.Size = new System.Drawing.Size(135, 25);
            gradeLevelLabel.TabIndex = 18;
            gradeLevelLabel.Text = "Grade Level:";
            // 
            // lastNameLabel1
            // 
            lastNameLabel1.AutoSize = true;
            lastNameLabel1.Location = new System.Drawing.Point(45, 52);
            lastNameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel1.Name = "lastNameLabel1";
            lastNameLabel1.Size = new System.Drawing.Size(121, 25);
            lastNameLabel1.TabIndex = 0;
            lastNameLabel1.Text = "Last Name:";
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Location = new System.Drawing.Point(45, 112);
            firstNameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new System.Drawing.Size(122, 25);
            firstNameLabel1.TabIndex = 2;
            firstNameLabel1.Text = "First Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(8, 174);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailAddressLabel
            // 
            emailAddressLabel.AutoSize = true;
            emailAddressLabel.Location = new System.Drawing.Point(13, 240);
            emailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailAddressLabel.Name = "emailAddressLabel";
            emailAddressLabel.Size = new System.Drawing.Size(156, 25);
            emailAddressLabel.TabIndex = 6;
            emailAddressLabel.Text = "Email Address:";
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.ColumnCount = 2;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this.topTableLayoutPanel.Controls.Add(this.mainMenuStrip, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.studentBindingNavigator, 1, 0);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 1;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(1323, 44);
            this.topTableLayoutPanel.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(814, 44);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentToolStripMenuItem,
            this.saveStudentToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitsavesDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 40);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newStudentToolStripMenuItem
            // 
            this.newStudentToolStripMenuItem.Name = "newStudentToolStripMenuItem";
            this.newStudentToolStripMenuItem.Size = new System.Drawing.Size(317, 44);
            this.newStudentToolStripMenuItem.Text = "&New Student";
            // 
            // saveStudentToolStripMenuItem
            // 
            this.saveStudentToolStripMenuItem.Name = "saveStudentToolStripMenuItem";
            this.saveStudentToolStripMenuItem.Size = new System.Drawing.Size(317, 44);
            this.saveStudentToolStripMenuItem.Text = "&Save Student";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentBySchoolToolStripMenuItem,
            this.studentsByProgramToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(317, 44);
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
            // exitsavesDataToolStripMenuItem
            // 
            this.exitsavesDataToolStripMenuItem.Name = "exitsavesDataToolStripMenuItem";
            this.exitsavesDataToolStripMenuItem.Size = new System.Drawing.Size(317, 44);
            this.exitsavesDataToolStripMenuItem.Text = "E&xit (saves data)";
            // 
            // studentBindingNavigator
            // 
            this.studentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentBindingNavigator.BindingSource = this.studentBindingSource;
            this.studentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.studentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentBindingNavigatorSaveItem});
            this.studentBindingNavigator.Location = new System.Drawing.Point(814, 0);
            this.studentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentBindingNavigator.Name = "studentBindingNavigator";
            this.studentBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.studentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentBindingNavigator.Size = new System.Drawing.Size(509, 44);
            this.studentBindingNavigator.TabIndex = 2;
            this.studentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 38);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DBWizard.Models.Student);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 38);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 38);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 38);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 38);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 38);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 38);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // studentBindingNavigatorSaveItem
            // 
            this.studentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentBindingNavigatorSaveItem.Enabled = false;
            this.studentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentBindingNavigatorSaveItem.Image")));
            this.studentBindingNavigatorSaveItem.Name = "studentBindingNavigatorSaveItem";
            this.studentBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 38);
            this.studentBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // student_pictureBox
            // 
            this.student_pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.student_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("student_pictureBox.Image")));
            this.student_pictureBox.Location = new System.Drawing.Point(16, 48);
            this.student_pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lastNameTextBox.Location = new System.Drawing.Point(249, 76);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(221, 31);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(512, 76);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(235, 31);
            this.firstNameTextBox.TabIndex = 5;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // student_idTextBox
            // 
            this.student_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "student_id", true));
            this.student_idTextBox.Location = new System.Drawing.Point(16, 279);
            this.student_idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.student_idTextBox.Name = "student_idTextBox";
            this.student_idTextBox.Size = new System.Drawing.Size(179, 31);
            this.student_idTextBox.TabIndex = 7;
            this.student_idTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.student_idTextBox_Validating);
            // 
            // dob_dateTimePicker
            // 
            this.dob_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob_dateTimePicker.Location = new System.Drawing.Point(16, 361);
            this.dob_dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dob_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dob_dateTimePicker.Name = "dob_dateTimePicker";
            this.dob_dateTimePicker.Size = new System.Drawing.Size(179, 31);
            this.dob_dateTimePicker.TabIndex = 9;
            this.dob_dateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.dob_dateTimePicker_Validating);
            // 
            // programComboBox
            // 
            this.programComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(512, 164);
            this.programComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(235, 33);
            this.programComboBox.TabIndex = 11;
            this.programComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(249, 250);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(221, 143);
            this.addressTextBox.TabIndex = 13;
            this.addressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // schoolComboBox
            // 
            this.schoolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "School.name", true));
            this.schoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.schoolComboBox.FormattingEnabled = true;
            this.schoolComboBox.Location = new System.Drawing.Point(512, 250);
            this.schoolComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.schoolComboBox.Name = "schoolComboBox";
            this.schoolComboBox.Size = new System.Drawing.Size(235, 33);
            this.schoolComboBox.TabIndex = 15;
            this.schoolComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "gender", true));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(252, 164);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(160, 33);
            this.genderComboBox.TabIndex = 17;
            this.genderComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // gradeLevelComboBox
            // 
            this.gradeLevelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "GradeLevel", true));
            this.gradeLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.gradeLevelComboBox.Location = new System.Drawing.Point(512, 359);
            this.gradeLevelComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradeLevelComboBox.Name = "gradeLevelComboBox";
            this.gradeLevelComboBox.Size = new System.Drawing.Size(160, 33);
            this.gradeLevelComboBox.TabIndex = 19;
            this.gradeLevelComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(19, 438);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(139, 68);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // parent_groupBox
            // 
            this.parent_groupBox.Controls.Add(emailAddressLabel);
            this.parent_groupBox.Controls.Add(this.emailAddressTextBox);
            this.parent_groupBox.Controls.Add(phoneNumberLabel);
            this.parent_groupBox.Controls.Add(this.phoneNumberNumericUpDown);
            this.parent_groupBox.Controls.Add(firstNameLabel1);
            this.parent_groupBox.Controls.Add(this.parent_firstNameTextBox);
            this.parent_groupBox.Controls.Add(lastNameLabel1);
            this.parent_groupBox.Controls.Add(this.parent_lastNameTextBox);
            this.parent_groupBox.Location = new System.Drawing.Point(808, 64);
            this.parent_groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parent_groupBox.Name = "parent_groupBox";
            this.parent_groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parent_groupBox.Size = new System.Drawing.Size(459, 294);
            this.parent_groupBox.TabIndex = 21;
            this.parent_groupBox.TabStop = false;
            this.parent_groupBox.Text = "Parent Information";
            // 
            // emailAddressTextBox
            // 
            this.emailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.EmailAddress", true));
            this.emailAddressTextBox.Location = new System.Drawing.Point(175, 236);
            this.emailAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailAddressTextBox.Name = "emailAddressTextBox";
            this.emailAddressTextBox.Size = new System.Drawing.Size(228, 31);
            this.emailAddressTextBox.TabIndex = 7;
            this.toolTips.SetToolTip(this.emailAddressTextBox, "Enter a valid email address with @");
            this.emailAddressTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailAddressTextBox_Validating);
            // 
            // phoneNumberNumericUpDown
            // 
            this.phoneNumberNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentBindingSource, "Parent.PhoneNumber", true));
            this.phoneNumberNumericUpDown.Location = new System.Drawing.Point(175, 174);
            this.phoneNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.phoneNumberNumericUpDown.Size = new System.Drawing.Size(229, 31);
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
            this.parent_firstNameTextBox.Location = new System.Drawing.Point(173, 109);
            this.parent_firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parent_firstNameTextBox.Name = "parent_firstNameTextBox";
            this.parent_firstNameTextBox.Size = new System.Drawing.Size(229, 31);
            this.parent_firstNameTextBox.TabIndex = 3;
            this.parent_firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // parent_lastNameTextBox
            // 
            this.parent_lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Parent.LastName", true));
            this.parent_lastNameTextBox.Location = new System.Drawing.Point(173, 49);
            this.parent_lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parent_lastNameTextBox.Name = "parent_lastNameTextBox";
            this.parent_lastNameTextBox.Size = new System.Drawing.Size(229, 31);
            this.parent_lastNameTextBox.TabIndex = 1;
            this.parent_lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.String_TextBox_Validating);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(225, 438);
            this.clear_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(155, 68);
            this.clear_button.TabIndex = 22;
            this.clear_button.Text = "Clear form for new student";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(427, 438);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(139, 68);
            this.delete_button.TabIndex = 23;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
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
            this.lblSearch.Location = new System.Drawing.Point(816, 369);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(304, 25);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search Student by Last Name:";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(821, 398);
            this.search_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(377, 31);
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
            this.btnChaosMonkey.Location = new System.Drawing.Point(633, 438);
            this.btnChaosMonkey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChaosMonkey.Name = "btnChaosMonkey";
            this.btnChaosMonkey.Size = new System.Drawing.Size(128, 82);
            this.btnChaosMonkey.TabIndex = 26;
            this.btnChaosMonkey.Text = "CHAOS MONKEY";
            this.btnChaosMonkey.UseVisualStyleBackColor = true;
            this.btnChaosMonkey.Click += new System.EventHandler(this.btnChaosMonkey_Click);
            // 
            // foundStudents_comboBox
            // 
            this.foundStudents_comboBox.FormattingEnabled = true;
            this.foundStudents_comboBox.Location = new System.Drawing.Point(827, 470);
            this.foundStudents_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foundStudents_comboBox.Name = "foundStudents_comboBox";
            this.foundStudents_comboBox.Size = new System.Drawing.Size(377, 33);
            this.foundStudents_comboBox.TabIndex = 27;
            this.foundStudents_comboBox.SelectionChangeCommitted += new System.EventHandler(this.foundStudents_comboBox_SelectionChangeCommitted);
            this.foundStudents_comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foundStudents_comboBox_KeyDown);
            // 
            // lblFoundStudents
            // 
            this.lblFoundStudents.AutoSize = true;
            this.lblFoundStudents.Location = new System.Drawing.Point(816, 438);
            this.lblFoundStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoundStudents.Name = "lblFoundStudents";
            this.lblFoundStudents.Size = new System.Drawing.Size(170, 25);
            this.lblFoundStudents.TabIndex = 28;
            this.lblFoundStudents.Text = "Found Students:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 562);
            this.Controls.Add(this.lblFoundStudents);
            this.Controls.Add(this.foundStudents_comboBox);
            this.Controls.Add(this.btnChaosMonkey);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.parent_groupBox);
            this.Controls.Add(this.save_button);
            this.Controls.Add(gradeLevelLabel);
            this.Controls.Add(this.gradeLevelComboBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(schoolLabel);
            this.Controls.Add(this.schoolComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.programComboBox);
            this.Controls.Add(programNameLabel);
            this.Controls.Add(this.dob_dateTimePicker);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(student_idLabel);
            this.Controls.Add(this.student_idTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.student_pictureBox);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "KentYouthDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingNavigator)).EndInit();
            this.studentBindingNavigator.ResumeLayout(false);
            this.studentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_pictureBox)).EndInit();
            this.parent_groupBox.ResumeLayout(false);
            this.parent_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator studentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentBindingNavigatorSaveItem;
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
    }
}

