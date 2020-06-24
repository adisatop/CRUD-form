using System;
using System.Windows.Forms;

namespace CRUD_FORM
{
    public partial class Create : Form
    {


        /// <summary>
        ///     פתח מערכת 
        /// </summary>
        public Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            Student student = new Student();
            student.name = name.Text; 
            student.studentClass = className.Text;
            
            if (student.name != null && student.name != "" ||
                student.studentClass != null && student.studentClass != "")
            {
                new DBManager().addStudent(student);
            }
            else {
                MessageBox.Show("Name or class cannot be empty! please try again");
            }
            
        }

    }
}
