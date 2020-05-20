namespace DBWizard
{
    partial class frmSchoolEditor
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
            System.Windows.Forms.Label schoolNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchoolEditor));
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolNameTextBox = new System.Windows.Forms.TextBox();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            schoolNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataSource = typeof(DBWizard.Models.School);
            // 
            // schoolNameLabel
            // 
            schoolNameLabel.AutoSize = true;
            schoolNameLabel.Location = new System.Drawing.Point(21, 19);
            schoolNameLabel.Name = "schoolNameLabel";
            schoolNameLabel.Size = new System.Drawing.Size(186, 20);
            schoolNameLabel.TabIndex = 1;
            schoolNameLabel.Text = "Enter New School Name:";
            // 
            // schoolNameTextBox
            // 
            this.schoolNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schoolBindingSource, "name", true));
            this.schoolNameTextBox.Location = new System.Drawing.Point(25, 54);
            this.schoolNameTextBox.Name = "schoolNameTextBox";
            this.schoolNameTextBox.Size = new System.Drawing.Size(182, 26);
            this.schoolNameTextBox.TabIndex = 2;
            this.schoolNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Location = new System.Drawing.Point(263, 26);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(81, 54);
            this.btnAddSchool.TabIndex = 3;
            this.btnAddSchool.Text = "Add School";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSchoolEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 123);
            this.Controls.Add(this.btnAddSchool);
            this.Controls.Add(schoolNameLabel);
            this.Controls.Add(this.schoolNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSchoolEditor";
            this.Text = "School Editor";
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource schoolBindingSource;
        private System.Windows.Forms.TextBox schoolNameTextBox;
        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}