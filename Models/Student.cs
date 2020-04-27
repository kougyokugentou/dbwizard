using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWizard.Models
{
    public class Student
    {
        public int id { get; }
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

        public virtual Parent Parent { get; set; }
        public virtual Program Program { get; set; }
        public virtual School School { get; set; }

        //override toString for search functionality.
        public override string ToString()
        {
            string str = $"{LastName}, {FirstName} student id: {student_id}";
            return str;
        }
    }
}
