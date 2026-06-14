static class DBConnection
{
    static string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=test_try;Integrated Security=True;Trust Server Certificate=True";
    public static SqlConnection _connection = new SqlConnection(_connectionString);
    public static void Initialte()
    {
        try
        {
            _connection.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Unable to connect to database\n{ex.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}