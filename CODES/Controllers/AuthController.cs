using Microsoft.Data.SqlClient;
using FormsApp.Models;
using FormsApp.Helpers;

namespace FormsApp.Controllers
{
    class AuthController
    {
        public bool Login(string username, string password)
        {
            // Ensure connection is up and running exactly like your seeder does
            DBConnection.Initialte();

            string query = @"
                SELECT a.UserId, a.UserName, a.Password, a.Status, 
                       e.EmployeeId, e.FirstName, e.LastName, e.Position, e.Gender, e.Age
                FROM Account a
                INNER JOIN Employee e ON a.UserId = e.UserId
                WHERE a.UserName = @UserName;";

            using (SqlCommand cmd = new SqlCommand(query, DBConnection._connection))
            {
                cmd.Parameters.AddWithValue("@UserName", username);
                
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // 1. Check account status safely
                            string statusStr = reader["Status"].ToString()!;
                            if (statusStr == "D") 
                            {
                                reader.Close(); // Explicitly close reader before shutting connection
                                DBConnection._connection.Close();
                                MessageBox.Show("This account has been deactivated.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }

                            string savedHash = reader["Password"].ToString()!;
                            
                            // 2. MUST use EnhancedVerify to match your seeder's EnhancedHashPassword
                            if (BCrypt.Net.BCrypt.EnhancedVerify(password, savedHash))
                            {
                                // Populate Global Session using your empty constructor pattern
                                UserSession.CurrentAccount = new Account
                                {
                                    UserId = (Guid)reader["UserId"],
                                    UserName = reader["UserName"].ToString()!,
                                    Status = string.IsNullOrEmpty(statusStr) ? 'A' : statusStr[0]
                                };

                                UserSession.CurrentEmployee = new Employee
                                {
                                    EmployeeId = (Guid)reader["EmployeeId"],
                                    FirstName = reader["FirstName"].ToString()!,
                                    LastName = reader["LastName"].ToString()!,
                                    Position = reader["Position"].ToString()!,
                                    Gender = Convert.ToChar(reader["Gender"]),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    UserId = UserSession.CurrentAccount.UserId
                                };

                                reader.Close();
                                DBConnection._connection.Close();
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Always guarantee the shared connection shuts down smoothly
                    if (DBConnection._connection.State == System.Data.ConnectionState.Open)
                    {
                        DBConnection._connection.Close();
                    }
                }
            }
            return false;
        }
    }
}