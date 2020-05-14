using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWizard.Models
{
    class ReportFull
    {
        public int id { get; set; }
        public string student_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string ProgramName { get; set; }
        public string SchoolName { get; set; }
        public string GradeLevel { get; set; }
        public string ParentFirstName { get; set; }
        public string ParentLastName { get; set; }
        public string ParentPhoneNumber { get; set; }
        public string ParentEmailAddress { get; set; }
    }
}
