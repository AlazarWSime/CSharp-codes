using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_exercise.DB
{
    static class DBConnection
    {
        static string _ConnectionString =
            @"Data Source=(LocalDb)\MSSQLLocalDB;
            Initial Catalog=TestDB;
            Integrated Security=True;
            Encrypt=False;
            TrustServerCertificate=True";

        public static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        public static void Initialte()
        {
            try
            {
                //Open the connection
                _Connection.Open();
                MessageBox.Show("Data base connected! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                        $"unable to connect database\n {ex.Message} ",
                        "DB ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        public static int ExecuteNonQuery(string query)
        {
           // SqlConnection Connection = new SqlConnection(_ConnectionString);// it's used to make a connection 
            //_Connection.Open();//uses the connection string defined above to actually open the SQL connection

            SqlCommand sqlCommand = new SqlCommand(query, _Connection);// it's used to send the query commands to the database
            //SqlCommand -> The type of object — it represents a SQL instruction
            //sqlCommand -> The variable name you give to this object

            //query -> The SQL statement you want to run e.g. "INSERT INTO Users VALUES('John')"
            //_Connection -> Tells the command which database connection to use

            // The connection knows WHERE to go
            // but SqlCommand tells it WHAT to do when it gets there
            return sqlCommand.ExecuteNonQuery();// ← now it actually sends the command
        }
    }

}

