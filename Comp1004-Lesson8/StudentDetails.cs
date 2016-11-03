using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Comp1004_Lesson8.Models;

namespace Comp1004_Lesson8
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            CollegeContext db = new CollegeContext();

            var Student = (from student in db.Students
                           select student).FirstOrDefault();

            FirstNameTextBox.Text = Student.FirstName;
            LastNameTextBox.Text = Student.LastName;
        }
    }
}
