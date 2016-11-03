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
using System.Diagnostics;

namespace Comp1004_Lesson8
{
    public partial class ListForm2 : Form
    {
        public ListForm2()
        {
            InitializeComponent();
        }

        private void ListForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myLocalServerDBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.myLocalServerDBDataSet.Students);

            CollegeContext db = new CollegeContext();

            var StudentList = (from student in db.Students
                               select student).ToList();

            StudentListDataGridView.DataSource = StudentList;
        }

        private void StudentListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowClicked = e.RowIndex;

            Debug.WriteLine(rowClicked);
        }
    }
}
