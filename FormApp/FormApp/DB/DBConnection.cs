using FormApp.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace FormApp.DB
{
    static class DBConnection
    {
        //create a private string to store the connection string
        //the connection string holds
        // * Data Source : the server name
        // => Data Source = the name of your computer/server
        // * Initial Catalog : The database name
        // => Initial Catalog = the name of your database
        // * Other MS SQL Configurations
        // => Other MS SQL Configurations = any other settings SQL Server needs
        // => These 3 lines explain the parts inside the connection string:"

        // Note: This connection string is just for MS SQL
        // Other servers would have there own connection string styles

        static string _connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=invetory_MS;
              Integrated Security=True;
              Encrypt=False;
              TrustServerCertificate=True";

        public static SqlConnection _Connection = new SqlConnection(_connectionString);

        public static void Initialte()
        {
            try 
            {
                _Connection.Open();
                //MessageBox.Show("Connected successuflly! ");
            }
            
            catch(Exception ex) 
            {
             MessageBox.Show
                    (
                       $"Unable to connect to database\n {ex.Message}",
                       "DB ERROR",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                    ); 
            }
            //_Connection.Close(); ?
        }
        public static int ExcuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, _Connection);
                if (parameters != null)                          // Step 3 - null check
                {
                    sqlCommand.Parameters.AddRange(parameters);  // Step 2 - attach params
                }

                int roawAffected = sqlCommand.ExecuteNonQuery();
                _Connection.Close();
                MessageBox.Show("Saved to database! ");
                return roawAffected;
                
            }
            catch (Exception ex) 
            {
                _Connection.Close();
                MessageBox.Show($"Query failed: {ex.Message}", "DB ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Connection.Close();
                return 0;
            }

        }


        public static SqlDataReader ExecuteReader(string query, SqlParameter[] parameters) 
        {
            try
            {
                _Connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, _Connection);

                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }

                return sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                _Connection.Close();
                MessageBox.Show($"Query failed: {ex.Message}", "DB ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
