using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    public class StudentInfo
    {

        private string studentID;
        private string lastname;
        private string firstname;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public StudentInfo() { }

        public StudentInfo(string studentID)
        {
            this.studentID = studentID;
        }
        public StudentInfo(string studentID, string lastName, string firstName)
        {
            this.studentID = studentID;
            this.LastName = lastName;
            this.FirstName = firstName;
        }

        public string GetStudentInfo()
        {
            return $"{StudentID} - {LastName}, {FirstName}";
        }
    }
}
