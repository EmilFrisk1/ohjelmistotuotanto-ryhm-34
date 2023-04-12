using System;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;

public class DatabaseManager
{
    private MySqlConnection _connection;
    private IConfiguration _configuration;
    private string _connectionString;

    public DatabaseManager()
    {
        var builder = new ConfigurationBuilder() // setup config json file 
              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        IConfiguration configuration = builder.Build();

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

    public async Task UpdateDataAsync(string tableName, Dictionary<string, object> columnValues, string conditionColumn, object conditionValue)
    {
        await ExecuteWithRetry(async (connection) =>
        {
            var setColumns = string.Join(", ", columnValues.Keys.Select(key => key + "=@" + key));

            using (MySqlCommand cmd = new MySqlCommand($"UPDATE {tableName} SET {setColumns} WHERE {conditionColumn}=@{conditionColumn}", connection))
            {
                foreach (var entry in columnValues)
                {
                    cmd.Parameters.AddWithValue("@" + entry.Key, entry.Value);
                }

                cmd.Parameters.AddWithValue("@" + conditionColumn, conditionValue);

                await cmd.ExecuteNonQueryAsync();
            }
        });
    }

    public async Task DeleteAsync(string tableName, string conditionColumn, object conditionValue)
    {
        await ExecuteWithRetry(async (connection) =>
        {
            using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM {tableName} WHERE {conditionColumn}=@{conditionColumn}", connection))
            {
                cmd.Parameters.AddWithValue("@" + conditionColumn, conditionValue);

                await cmd.ExecuteNonQueryAsync();
            }
        });
    }

    public async Task<List<Dictionary<string, object>>> SelectAsync(string tableName, string conditionColumn = null, object conditionValue = null, List<string> columns = null)
    {
        List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

        await ExecuteWithRetry(async (connection) =>
        {
            string selectedColumns = columns != null ? string.Join(", ", columns) : "*";
            string whereClause = (conditionColumn != null && conditionValue != null) ? $"WHERE {conditionColumn}=@{conditionColumn}" : "";

            using (MySqlCommand cmd = new MySqlCommand($"SELECT {selectedColumns} FROM {tableName} {whereClause}", connection))
            {
                if (conditionColumn != null && conditionValue != null)
                {
                    cmd.Parameters.AddWithValue("@" + conditionColumn, conditionValue);
                }

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }
        });

        return results;
    }


}
