using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void vtnAdd_Click(object sender, EventArgs e)
        {

            string studentID = txtStudentID.Text;
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;

            StudentInfo studyante = new StudentInfo(studentID, lastName, firstName);

            lstStudentID.Items.Add(studyante.StudentID);
            lstLastName.Items.Add(studyante.LastName);
            lstFirstName.Items.Add(studyante.FirstName);

            txtStudentID.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
        }
    }
}
