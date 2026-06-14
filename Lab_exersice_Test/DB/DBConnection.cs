using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_exersice_Test.DB
{
    static class DBConnection
    {
      static string _ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=TestDB; 
              Integrated Security=True;
              Encrypt=False;
              TrustServerCertificate=True";

      public static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        public static void initiate()
        {
            try
            {
                if(_Connection.State is System.Data.ConnectionState.Open)
                _Connection.Open();
                MessageBox.Show("Database connected Successfully!! ");
            }

            catch (Exception ex)
            {
                MessageBox.Show
                (
                    $"Unable to connect to the database\n {ex.Message}",
                    "DB ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public static int ExcuteNonQuery(string query) 
        {
            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, _Connection);
                int rowAffected = sqlCommand.ExecuteNonQuery();
                _Connection.Close();
                MessageBox.Show("Saved to database! ");
                return rowAffected;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Query failed: {ex.Message}", "DB ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Connection.Close();
                return 0;
            }
           
        }
            
        
    }

}