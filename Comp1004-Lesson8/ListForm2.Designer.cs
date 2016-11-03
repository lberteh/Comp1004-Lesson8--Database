namespace Comp1004_Lesson8
{
    partial class ListForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StudentListDataGridView = new System.Windows.Forms.DataGridView();
            this.myLocalServerDBDataSet = new Comp1004_Lesson8.MyLocalServerDBDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Comp1004_Lesson8.MyLocalServerDBDataSetTableAdapters.StudentsTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLocalServerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentListDataGridView
            // 
            this.StudentListDataGridView.AutoGenerateColumns = false;
            this.StudentListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.StudentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.programDescriptionDataGridViewTextBoxColumn});
            this.StudentListDataGridView.DataSource = this.studentsBindingSource;
            this.StudentListDataGridView.GridColor = System.Drawing.Color.White;
            this.StudentListDataGridView.Location = new System.Drawing.Point(68, 67);
            this.StudentListDataGridView.Name = "StudentListDataGridView";
            this.StudentListDataGridView.Size = new System.Drawing.Size(493, 237);
            this.StudentListDataGridView.TabIndex = 0;
            this.StudentListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentListDataGridView_CellContentClick);
            // 
            // myLocalServerDBDataSet
            // 
            this.myLocalServerDBDataSet.DataSetName = "MyLocalServerDBDataSet";
            this.myLocalServerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.myLocalServerDBDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // programDescriptionDataGridViewTextBoxColumn
            // 
            this.programDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProgramDescription";
            this.programDescriptionDataGridViewTextBoxColumn.HeaderText = "Program Description";
            this.programDescriptionDataGridViewTextBoxColumn.Name = "programDescriptionDataGridViewTextBoxColumn";
            this.programDescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // ListForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 468);
            this.Controls.Add(this.StudentListDataGridView);
            this.Name = "ListForm2";
            this.Text = "Students List";
            this.Load += new System.EventHandler(this.ListForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLocalServerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentListDataGridView;
        private MyLocalServerDBDataSet myLocalServerDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private MyLocalServerDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDescriptionDataGridViewTextBoxColumn;
    }
}