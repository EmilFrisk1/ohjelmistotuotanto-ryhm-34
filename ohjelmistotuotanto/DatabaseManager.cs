using System;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;

public class DatabaseManager
{
    private MySqlConnection _connection;
    private IConfiguration _configuration;
    private string _connectionString;

    public DatabaseManager(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("MySqlConnection");
    }

    // Add other database-related methods here, e.g., for querying or updating the database

    public void CloseConnection()
    {
        if (_connection != null)
        {
            _connection.Close();
        }
    }

    // 1. Connect 2. Database operation 3. disconnect || 3 max tries
    public async Task ExecuteWithRetry(Func<MySqlConnection, Task> operation) 
    {
        int maxAttempts = 3;
        int currentAttempt = 0;

        while (currentAttempt < maxAttempts)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    await operation(connection);

                    connection.Close();
                }

                // If the operation is successful, break out of the loop
                break;
            }
            catch (MySqlException ex)
            {
                currentAttempt++;

                if (currentAttempt == maxAttempts)
                {
                    MessageBox.Show($"Error connecting to the database after {maxAttempts} attempts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    await Task.Delay(1000);
                }
            }
        }
    }


    public async Task InsertArea(string areaName)
    {
        await ExecuteWithRetry(async (connection) =>
        {
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO area (name) VALUES (@areaName)", connection))
            {
                cmd.Parameters.AddWithValue("@areaName", areaName);

                await cmd.ExecuteNonQueryAsync();
            }
        });
    }
}
