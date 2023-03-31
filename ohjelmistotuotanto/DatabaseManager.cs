using System;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;

public class DatabaseManager
{
    private MySqlConnection _connection;
    private IConfiguration _configuration;

    public DatabaseManager(IConfiguration configuration)
    {
        _configuration = configuration;
        Connect();
    }

    private async void Connect()
    {
        string connectionString = _configuration.GetConnectionString("MySqlConnection");
        _connection = new MySqlConnection(connectionString);

        int maxAttempts = 3;
        int currentAttempt = 0;
        bool connected = false;

        while (currentAttempt < maxAttempts && !connected) //  try to connect 3 times if failure
        {
            try
            {
                _connection.Open();
                MessageBox.Show("Connection to the database was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connected = true;
            }
            catch (MySqlException ex)
            {
                currentAttempt++;

                if (currentAttempt == maxAttempts)
                {
                    MessageBox.Show($"Error connecting to the database after {maxAttempts} attempts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    await Task.Delay(1000);
                }
            }
        }
    }

    // Add other database-related methods here, e.g., for querying or updating the database

    public void CloseConnection()
    {
        if (_connection != null)
        {
            _connection.Close();
        }
    }


    public void InsertArea(string column1Value)
    {
        try
        {
            using (MySqlCommand cmd = new MySqlCommand("INSERT INTO area (name) VALUES (@column1Value)", _connection))
            {
                cmd.Parameters.AddWithValue("@column1Value", column1Value);

                cmd.ExecuteNonQuery();
            }
        }
        catch (MySqlException ex)
        {
            // Handle errors, e.g., by logging the exception or showing an error message
            Console.WriteLine($"Error inserting data into the database: {ex.Message}");
        }
    }

}
