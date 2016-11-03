namespace Comp1004_Lesson8
{
    partial class StudentListForm
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
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Location = new System.Drawing.Point(62, 59);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.Size = new System.Drawing.Size(566, 367);
            this.StudentsDataGridView.TabIndex = 0;
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 498);
            this.Controls.Add(this.StudentsDataGridView);
            this.Name = "StudentListForm";
            this.Text = "Student List ";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDataGridView;
    }
}

