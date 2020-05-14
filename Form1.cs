using CsvHelper;
using DBWizard.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/* References 
 * https://www.youtube.com/watch?v=ayp3tHEkRc0
 * https://www.coderslexicon.com/passing-data-between-forms-using-delegates-and-events/
 * https://dapper-tutorial.net/parameter-anonymous
 * https://www.sqlitetutorial.net/sqlite-foreign-key/
 * https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
 * https://stackoverflow.com/questions/9173904/byte-array-to-image-conversion
  */

namespace DBWizard
{
    public partial class Form1 : Form
    {
        //Global instance of the SqliteDataAccess object.
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        const string DEFAULT_PIC_TAG = "DefaultPic";
        const string CUSTOM_PIC_TAG = "dickpic";

        public Form1()
        {
            InitializeComponent();
        }

        //Needed to populate the pre-filled comboboxes. Do not remove.
        private void Form1_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        /* Fills program and school combo boxes on the form
         * with the static data from the sqlite db.
         * input: no input
         * output: void
         */
        private void FillComboBoxes()
        {
            List<Program> programs = new List<Program>();
            programs = SqliteDataAccess.GetPrograms();

            foreach (Program p in programs)
            {
                programComboBox.Items.Add(p.name);
            }
            
            List<School> schools = new List<School>();
            schools = SqliteDataAccess.GetSchools();
            foreach (School s in schools)
            {
                schoolComboBox.Items.Add(s.name);
            }
        }

        /* On click of the picture box, open a file picker dialog box
         * for the user to browse/choose a picture.
         * Once the user clicks OK, the _FileOK event below fires,
         * validates the input. If file is OK, then read the file from disk,
         * convert it into an Image, and save it to the student picture box.
         */
        private void student_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = pic_openFileDialog.ShowDialog();
            byte[] pic_in;

            if (dr == DialogResult.OK)
            {
                try
                {
                    //Read picture
                    pic_in = File.ReadAllBytes(pic_openFileDialog.FileName);
                    Image dickPic = ByteArrayToImage(pic_in);

                    //Place in dicpic box
                    student_pictureBox.Image = dickPic;

                    //change tag of pic box to something else
                    student_pictureBox.Tag = CUSTOM_PIC_TAG;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to read selected file, try again.", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }
        }

        /* Event that occurs when the user clicks Open in the file dialog box.
         * Check to see if the photo size is too large for the database.
         * If so, reject the file and inform the user.
         */
        private void pic_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            byte[] dickpic;

            //Chunk file into bytes.
            //If file > 2147483647 bytes long, reject file.
            dickpic = ImageToByteArray(student_pictureBox.Image);
            if (dickpic.Length >= 2147483647) //THAT'S WHAT SHE SAID
            {
                MessageBox.Show("The selected student photo size is too large. Choose a smaller photo size or shrink the photo.", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
        }

        /* Event that fires when user clicks the save button or 
         * chooses File > Save Student.
         * 
         * Saves student to database.
         * If existing student, update student.
         * If new student, insert student.
         */
        private void save_button_Click(object sender, EventArgs e)
        {
            byte[] dickpic;

            //Perform sanity check, ensure all data is filled except picture
            this.Validate();

            // Check to see if any control is in error.
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    MessageBox.Show("Student not saved due to errors on the form!", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }

            //if pic is not default pic,
            if(student_pictureBox.Tag.ToString() != DEFAULT_PIC_TAG)
            {
                //Validate the picture is under 2147483647 characters in length.
                dickpic = ImageToByteArray(student_pictureBox.Image);
                if (dickpic.Length >= 2147483647) //THAT'S WHAT SHE SAID
                {
                    MessageBox.Show("The selected student photo size is too large. Choose a smaller photo size or shrink the photo.", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
            }

            //Collect form data in student object
            Student student = new Student();
            student.student_id = student_idTextBox.Text;
            student.FirstName = firstNameTextBox.Text;
            student.LastName = lastNameTextBox.Text;
            student.DOB = dob_dateTimePicker.Value.ToString();
            student.gender = genderComboBox.Text;
            student.address = addressTextBox.Text;
            student.program_id = programComboBox.SelectedIndex + 1;
            student.school_id = schoolComboBox.SelectedIndex + 1;
            student.GradeLevel = gradeLevelComboBox.Text;

            if (student_pictureBox.Tag.ToString() == DEFAULT_PIC_TAG)
                student.photo = null;
            else
                student.photo = ImageToByteArray(student_pictureBox.Image);

            //collect parent
            Parent parent = new Parent();
            parent.LastName = parent_lastNameTextBox.Text;
            parent.FirstName = parent_firstNameTextBox.Text;
            parent.PhoneNumber = long.Parse(phoneNumberNumericUpDown.Value.ToString());
            parent.EmailAddress = emailAddressTextBox.Text;

            //save data to sqldb.
            //update existing student.
            if(SqliteDataAccess.GetStudentByDbID(Int32.Parse(studentDbID.Value.ToString())) != null)
            {
                student.id = Int32.Parse(studentDbID.Value.ToString());
                parent.parent_id = Int32.Parse(parentDbID.Value.ToString());

                SqliteDataAccess.UpdateStudent(student);
                SqliteDataAccess.UpdateParent(parent);
                MessageBox.Show("Student and parent successfully updated.", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else //new student
            {
                student.parent_id = SqliteDataAccess.InsertNewParent(parent);
                SqliteDataAccess.InsertNewStudent(student);
                MessageBox.Show("Student successfully added", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClearForm();
            }
        }

        /* Convert student photo to byte array for saving to db.
         * Also used to see if the photo is too large for the db blob type.
         * INPUT: Object
         * OUPUT byte[] array
         * https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
         */
        private byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
                return null;

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        /* Convert student photo from byte array to object.
         * Convert a byte array to an Object
         * INPUT: byte[] array
         * OUTPUT: Image
         * https://stackoverflow.com/questions/9173904/byte-array-to-image-conversion
         */
        private Image ByteArrayToImage(byte[] arrBytes)
        {
            using (var ms = new MemoryStream(arrBytes))
            {
                return Image.FromStream(ms);
            }
        }

        // Basic input validation on a string given a textbox control
        // ensures only values a-z, with length two or greater.
        private void String_TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!Regex.IsMatch(tb.Text, "[A-Za-z]{2,}"))
                errorProvider1.SetError(tb, "Enter a value a-z only of length two or longer.");
            else
                errorProvider1.SetError(tb, "");
        }

        //Validates any given combobox to ensure an item is selected.
        private void ComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            if (cb.SelectedIndex < 0)
                { errorProvider1.SetError(cb, "Select an item."); }
            else
                { errorProvider1.SetError(cb, ""); }
        }

        /* Does not really check to see if it is a valid phone number
         * since the phone companies introduce new area codes all the damn time.
         * Only checks to see the most likely case that the user of the program
         * has left the phone number value as the default minimum value.
         */
        private void phoneNumberNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            if(phoneNumberNumericUpDown.Value == phoneNumberNumericUpDown.Minimum 
            || phoneNumberNumericUpDown.Value == phoneNumberNumericUpDown.Maximum)
                { errorProvider1.SetError(phoneNumberNumericUpDown, "Type in a valid phone number"); }
            else
                { errorProvider1.SetError(phoneNumberNumericUpDown, "");  }
        }

        /* Checks to see if provided email address is valid
         * by matching against an email address regex i stole from the interweb.
         */
        private void emailAddressTextBox_Validating(object sender, CancelEventArgs e)
        {
            //email address regex
            //^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$
            if (!Regex.IsMatch(emailAddressTextBox.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,5}$"))
                errorProvider1.SetError(emailAddressTextBox, "Enter a valid email address: user@domain.com");
            else
                errorProvider1.SetError(emailAddressTextBox, "");
        }

        /* Validation of DOB Date Time Picker does not really do any validation
         * other than check the basic, most probable case of the date is still today.
         * Yes, the Student can literally be born yesterday, and in 12th grade.
         * Paradox, ahoy!
         */
        private void dob_dateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if(dob_dateTimePicker.Value == DateTime.Now)
                { errorProvider1.SetError(dob_dateTimePicker, "Please choose DOB."); }
            else
                { errorProvider1.SetError(dob_dateTimePicker, ""); }
        }

        //Since not sure if student ID textbox can contain numbers
        //this is seperate from generic textbox which is only letters.
        private void student_idTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!Regex.IsMatch(tb.Text, "[A-Za-z0-9]{2,}"))
                errorProvider1.SetError(tb, "Enter a value a-z0-9 only of length two or longer.");
            else
                errorProvider1.SetError(tb, "");

        }

        //Button to clear the form, exactly as it says on the tin.
        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /* clears the form
         * Does this by looping through all the controls and setting them to null
         * or to default values. Be sure to set student textbox tag to DefaultImage.
         */
        private void ClearForm()
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = null;
                }
                
                if(c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.SelectedIndex = -1;
                }

                if(c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Value = DateTime.Today;
                }

                if(c is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)c;
                    nud.Value = nud.Minimum;
                }

                //Be sure to set the student textbox tag to DefaultImage
                //or you will be in for a really bad time.
                if(c is PictureBox)
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = Properties.Resources.student;
                    pb.Tag = DEFAULT_PIC_TAG;
                }
            } // foreach

            //clear dbid values
            studentDbID.Value = 0;
            parentDbID.Value = 0;

            //clear parent data
            parent_lastNameTextBox.Text = string.Empty;
            parent_firstNameTextBox.Text = string.Empty;
            phoneNumberNumericUpDown.Value = phoneNumberNumericUpDown.Minimum;
            emailAddressTextBox.Text = string.Empty;

            ClearFoundStudentsComboBox();
            ClearFormErrors();
        } //ClearForm()

        /* Clears form errors out of the errorprovider.
         * INPUTS: no args
         * OUTPUT: void
         */
        private void ClearFormErrors()
        {
            //clear form errors
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                errorProvider1.SetError(c, "");
            }
        }

        //Clears the found student combobox.
        private void ClearFoundStudentsComboBox()
        {
            foundStudents_comboBox.DataSource = null;
            foundStudents_comboBox.Items.Clear();
            foundStudents_comboBox.Text = string.Empty;
            foundStudents_comboBox.SelectedIndex = -1;
        }

        /* Implements main search functionality by taking in whatever
         * is typed in the search box. If the enter key is pressed,
         * will execute search of the db based on last name and return
         * found results or not found to the foundStudents combobox.
         */
        private void search_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            List<Student> foundStudents = new List<Student>();

            if (e.KeyCode == Keys.Enter)
            {
                ClearFoundStudentsComboBox();

                foundStudents = SqliteDataAccess.FindStudentByLastname(search_textBox.Text);

                foundStudents_comboBox.DataSource = foundStudents;
                foundStudents_comboBox.DisplayMember = "DisplayName";
                foundStudents_comboBox.Text = (foundStudents.Count > 0) ? "Students found, click here" : "No students found";
            }
        }

        //Do nothing if the user tries to type in the found student combobox.
        private void foundStudents_comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        /* When the user clicks on a found student,
         * automatically populate the form based on the found student
         * and that student's parent.
         */
        private void foundStudents_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Student foundStudent = foundStudents_comboBox.SelectedItem as Student;
            ClearForm();

            //The found students combo box is not completely
            //cleared upon clearform. Do this now.
            //ClearFoundStudentsComboBox();

            //Populate the form based on the found student.
            studentDbID.Value = foundStudent.id;
            lastNameTextBox.Text = foundStudent.LastName;
            firstNameTextBox.Text = foundStudent.FirstName;
            programComboBox.SelectedIndex = foundStudent.program_id-1;
            schoolComboBox.SelectedIndex = foundStudent.school_id-1;
            addressTextBox.Text = foundStudent.address;
            student_idTextBox.Text = foundStudent.student_id;
            dob_dateTimePicker.Value = DateTime.Parse(foundStudent.DOB);

            //May need to select the index on these comboboxes.
            genderComboBox.Text = foundStudent.gender;
            gradeLevelComboBox.Text = foundStudent.GradeLevel;

            //If the found student photo is not null, convert it to an image.
            //else, set the student picture box to the default image.
            //TODO: Test to see if pictureBox.tag needs updating here.
            student_pictureBox.Image = (foundStudent.photo != null) ? ByteArrayToImage(foundStudent.photo) : Properties.Resources.student;

            //Now populate the parent.
            Parent stuParent = new Parent();
            stuParent = SqliteDataAccess.GetParentByID(foundStudent.parent_id);

            parent_lastNameTextBox.Text = stuParent.LastName;
            parent_firstNameTextBox.Text = stuParent.FirstName;
            phoneNumberNumericUpDown.Value = stuParent.PhoneNumber;
            emailAddressTextBox.Text = stuParent.EmailAddress;
            parentDbID.Value = stuParent.parent_id;

            //Clear form errors, if any.
            ClearFormErrors();

        } //foundStudents_comboBox_SelectionChangeCommitted
        
        /* Deletes a student.
         * Note that you must FIRST, FIND the student, then click on them
         * in the drop-down menu to have the form populate, then this
         * function will work to delete both the student and the parent
         * from the backend database.
         */
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (studentDbID.Value <= 0)
                return;

            //collect up the student and parent.
            Student stu = SqliteDataAccess.GetStudentByDbID(Int32.Parse(studentDbID.Value.ToString()));
            Parent par = SqliteDataAccess.GetParentByID(stu.parent_id);

            //Nerf 'em.
            SqliteDataAccess.DeleteStudent(stu);
            SqliteDataAccess.DeleteParent(par);

            //Dispose of the objects.
            ClearForm();
            MessageBox.Show("Student deleted from database.", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        #region redundancy
        /* This whole region of code simply implements the File menu
         * which only calls the previously programmed delegates for saving a student,
         * or creating a new student. Henceforth, I present to you the redundancy region.
         */
        private void exitWithoutSavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exitsavesDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Error handling happens on the save_button_Click event, so no need to do it here.
            save_button_Click(save_button, EventArgs.Empty);

            //If there's an error, oh well, we tried, exit anyway.
            Environment.Exit(0);
        }
        #endregion

        /* Exports the data from the database into readable format.
         * INPUT: no args
         * OUTPUT: File to disk.
         */
        private void exportAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Build the default filename
            saveFileDialogReport.FileName = DateTime.Now.ToString("yy.MM.dd") + "-report.csv";

            if (saveFileDialogReport.ShowDialog() == DialogResult.OK
            && saveFileDialogReport.FileName != "")
            {
                string filename = saveFileDialogReport.FileName;

                List<ReportFull> report = new List<ReportFull>();
                report = SqliteDataAccess.GetFullDBDump();


                TextWriter textWriter = new StreamWriter(filename);
                CsvWriter csvWriter = new CsvWriter(textWriter);
                csvWriter.WriteRecords(report);

                textWriter.Close();
                MessageBox.Show("Report Generated", "KentYouthDB", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

        }
    } //Form1
}
