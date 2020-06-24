using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_FORM
{
    public partial class ShowAll : Form
    {
        public ShowAll()
        {
            InitializeComponent();
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DBManager().getAllStudents();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        { 
            int row = e.RowIndex;
            DataGridViewRow r =  dataGridView1.Rows[row]; //  whats's your row? 
            int id = (int )r.Cells[0].Value; // give me the value of id cell 
            Console.WriteLine( "the id of student: "+id);

            /// finding which field to update
            int columnIndex = e.ColumnIndex;
            DataGridViewColumn column = dataGridView1.Columns[columnIndex];
           string fieldName = column.HeaderText

            
            /// create student object with updated data

            






        }
    }
}
