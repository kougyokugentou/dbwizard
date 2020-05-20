using DBWizard.Models;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DBWizard
{
    public partial class frmSchoolEditor : Form
    {
        public frmSchoolEditor()
        {
            InitializeComponent();
        }

        /* Ensure the new school textbox has something in it.
         * INPUT: no args
         * OUTPUT: File to disk.
         */
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!Regex.IsMatch(tb.Text, "[A-Za-z]{2,}"))
                errorProvider1.SetError(tb, "Enter a value a-z only of length two or longer.");
            else
                errorProvider1.SetError(tb, "");
        }

        /* Adds a new school to the SQLite database.
         * INPUT: string schoolname
         * OUTPUT: New row to sqlite database
         */

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            School NewSchool;
            SqliteDataAccess SqliteDataAccess2 = new SqliteDataAccess();

            // validate the form
            // Check to see if any control is in error.
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    MessageBox.Show("School not saved due to errors on the form!", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }

            //Check to see if the school is already in the database.
            //if so, do not add the school to the DB again.
            NewSchool = SqliteDataAccess2.GetSchoolByName(schoolNameTextBox.Text);
            if(NewSchool != null)
            {
                MessageBox.Show("School already exists in the database, not saved.", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

            //Create a new school object and collect up the data.
            NewSchool = new School();
            NewSchool.name = schoolNameTextBox.Text;

            //insert the new school to the backend db
            SqliteDataAccess2.InsertNewSchool(NewSchool);

            //Display a friendly message and cleanup the textbox for any new entry.
            MessageBox.Show("School added to the database.", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
            schoolNameTextBox.Text = string.Empty;
        }
    }
}
