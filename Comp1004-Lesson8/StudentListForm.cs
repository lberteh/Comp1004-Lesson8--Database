using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// in order to access the db context, we need to include models folder in our script
using Comp1004_Lesson8.Models;

namespace Comp1004_Lesson8
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void GetStudents()
        {
            // connect to the db using entity framework
            CollegeContext db = new CollegeContext();

            // using LINQ to access the student table in the db
            var StudentsList = (from student in db.Students // using var keyword cause it implicitly tells me data type
                                select student).ToList();

            StudentsDataGridView.DataSource = StudentsList;
        }
    }
}
