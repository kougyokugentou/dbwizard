using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWizard.Models
{
    public class Student
    {
        public int id { get; set; }
        public string student_id { get; set; }
        public int parent_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public int program_id { get; set; }
        public int school_id { get; set; }
        public string GradeLevel { get; set; }
        public byte[] photo { get; set; }

        //readonly property to populate the found student searchbox.
        // this is a "Get" only property
        public string DisplayName{
            get =>
                $"{LastName}, {FirstName} - Student ID: {student_id}";
        }

        public virtual Parent Parent { get; set; }
        public virtual Program Program { get; set; }
        public virtual School School { get; set; }
    }
}
