using System;
using System.Data;
using System.Linq; // Required for .OrderBy() and .ToArray()
using Microsoft.Data.SqlClient;
using FormsApp.Models;
using FormsApp.Data;

namespace FormsApp.Controllers
{
    class AdminController
    {
        // Your Custom Username Generator (Fixed Typos)
        private string GenerateUsername(string Fn, string Ln, Guid Uid)
        {
            // Substring(0, 4) takes the FIRST 4 digits as you provided, 
            // but if you want the LAST 4 digits to match Super_Admin@0305, 
            // you can use: string uidStr = Uid.ToString(); return $"{Fn}_{Ln}@{uidStr.Substring(uidStr.Length - 4)}";
            return $"{Fn}_{Ln}@{Uid.ToString().Substring(0, 4)}";
        }

        // Your Custom Strong Password Generator (Fixed Typos)
        private string GenerateRandomPassword()
        {
            string caps = "ABCDEFGHIJKLMNOPQRSTUVWYZ";
            string spec = "!@#$%&*_";
            string lower = "abcdefghijklmnopqrstuvwxyz";
            string num = "0123456789";
            Random rnd = new Random();
            string password = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                password = password.Insert(i, caps[rnd.Next(caps.Length)].ToString());
                password = password.Insert(i, lower[rnd.Next(lower.Length)].ToString());
                password = password.Insert(i, num[rnd.Next(num.Length)].ToString()); // Fixed missing )
                password = password.Insert(i, spec[rnd.Next(spec.Length)].ToString());
            }
            // Fixed Ind to rnd
            return new string(password.OrderBy(x => rnd.Next()).ToArray());
        }

        // 1. REVISED ADD EMPLOYEE METHOD
        public string AddEmployee(string firstName, string lastName, char gender, int age, string position)
        {
            DBConnection.Initialte();

            Account newAcc = new Account();
            Employee newEmp = new Employee();

            // Use your custom methods to create credentials dynamically
            string username = GenerateUsername(firstName, lastName, newAcc.UserId);
            string plainPassword = GenerateRandomPassword();
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(plainPassword);

            string accountSql = "INSERT INTO Account (UserId, UserName, Password, Status) VALUES (@UserId, @UserName, @Password, 'A');";
            string employeeSql = "INSERT INTO Employee (EmployeeId, FirstName, LastName, Gender, Age, Position, UserId) VALUES (@EmployeeId, @FirstName, @LastName, @Gender, @Age, @Position, @UserId);";

            SqlTransaction tr = DBConnection._connection.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand(accountSql, DBConnection._connection, tr))
                {
                    cmd.Parameters.AddWithValue("@UserId", newAcc.UserId);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand(employeeSql, DBConnection._connection, tr))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", newEmp.EmployeeId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Gender", gender.ToString());
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@UserId", newAcc.UserId);
                    cmd.ExecuteNonQuery();
                }

                tr.Commit();
                DBConnection._connection.Close();

                return $"SUCCESS|{username}|{plainPassword}";
            }
            catch (Exception ex)
            {
                tr.Rollback();
                DBConnection._connection.Close();
                return $"ERROR|{ex.Message}";
            }
        }

        // 2. REVISED UPDATE EMPLOYEE METHOD
        public bool UpdateEmployee(Guid employeeId, Guid userId, string firstName, string lastName, char gender, int age, string position)
        {
            DBConnection.Initialte();

            // Automatically updates username using your custom rule if first/last name changes!
            string updatedUsername = GenerateUsername(firstName, lastName, userId);

            string updateEmployeeSql = @"UPDATE Employee 
                                         SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Age = @Age, Position = @Position 
                                         WHERE EmployeeId = @EmployeeId;";

            string updateAccountSql = "UPDATE Account SET UserName = @UserName WHERE UserId = @UserId;";

            SqlTransaction tr = DBConnection._connection.BeginTransaction();

            try
            {
                using (SqlCommand cmd = new SqlCommand(updateEmployeeSql, DBConnection._connection, tr))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Gender", gender.ToString());
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand(updateAccountSql, DBConnection._connection, tr))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@UserName", updatedUsername);
                    cmd.ExecuteNonQuery();
                }

                tr.Commit();
                DBConnection._connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                tr.Rollback();
                DBConnection._connection.Close();
                System.Windows.Forms.MessageBox.Show($"Update failed: {ex.Message}");
                return false;
            }
        }

        // Rest of your views/delete methods remain exactly the same...
        public DataTable GetAllEmployees() { /* ... */ return new DataTable(); }
        public bool SoftDeleteEmployee(Guid userId) { /* ... */ return true; }
        public DataTable GetActiveAccounts() { /* ... */ return new DataTable(); }
        public bool ToggleAccountStatus(Guid userId, string currentStatus) { /* ... */ return true; }
    }
}