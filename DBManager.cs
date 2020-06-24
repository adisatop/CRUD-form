using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_FORM
{
    class DBManager
    {

        SqlConnection cnn;
        String connectionUrl = @"Data Source=localhost;Initial Catalog=tech-career;Integrated Security=SSPI;persist security info=True;";
        
        internal Student addStudent(Student student)
        {   
            using (SqlConnection conn = new SqlConnection(connectionUrl))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO students(name,studentClass)VALUES('"+student.name+"','"+student.studentClass+"')", conn);
                int rowsEffected = command.ExecuteNonQuery();
            }
            return student;

        }

        public DataTable getAllStudents()
        {
            DataTable dataTable;
            using (SqlConnection conn = new SqlConnection(connectionUrl))
            {
                conn.Open();
                SqlDataAdapter command = new SqlDataAdapter("SELECT *  FROM students", conn);
                dataTable = new DataTable();
                command.Fill(dataTable);
            }
            return dataTable;
        }

    }

   
   
}
