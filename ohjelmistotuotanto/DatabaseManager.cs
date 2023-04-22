using System;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;

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
    public async Task<int> ExecuteWithRetry(Func<MySqlConnection, Task<int>> operation)
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

                    int result = await operation(connection);

                    connection.Close();

                    // If the operation is successful, return the result
                    return result;
                }
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

        // Return default value if operation fails after maxAttempts
        return -1;
    }

    public async Task<int> InsertDataAsync(string tableName, Dictionary<string, object> columnValues)
    {
        int affectedRows = await ExecuteWithRetry(async (connection) =>
        {
            var columns = string.Join(", ", columnValues.Keys);
            var parameters = string.Join(", ", columnValues.Keys.Select(key => "@" + key));

            using (MySqlCommand cmd = new MySqlCommand($"INSERT INTO {tableName} ({columns}) VALUES ({parameters})", connection))
            {
                foreach (var entry in columnValues)
                {
                    cmd.Parameters.AddWithValue("@" + entry.Key, entry.Value);
                }

                return await cmd.ExecuteNonQueryAsync();
            }
        });

        return affectedRows;
    }

    public async Task<int> CallCheckAvailabilityAndReserveAsync(int cottageId, string startDate, string endDate, int customerId)
    {
        int reservationId = -1;

        reservationId = await ExecuteWithRetry(async (connection) =>
        {
            using (MySqlCommand cmd = new MySqlCommand("check_availability_and_reserve", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_cottage_id", cottageId);
                cmd.Parameters.AddWithValue("@p_start_date", startDate);
                cmd.Parameters.AddWithValue("@p_end_date", endDate);
                cmd.Parameters.AddWithValue("@p_customer_id", customerId);

                cmd.Parameters.Add(new MySqlParameter("@p_reservation_id", MySqlDbType.Int32));
                cmd.Parameters["@p_reservation_id"].Direction = ParameterDirection.Output;

                await cmd.ExecuteNonQueryAsync();

                reservationId = (int)cmd.Parameters["@p_reservation_id"].Value;
                return reservationId;
            }
        });

        return reservationId;
    }

    //public async Task checkAvailabilityAndReserve(int cottageId, int customerId, startDate, endDate)
    //{
    //    await ExecuteWithRetry(async (connection) =>
    //    {
    //        var columns = string.Join(", ", columnValues.Keys);
    //        var parameters = string.Join(", ", columnValues.Keys.Select(key => "@" + key));

    //        using (MySqlCommand cmd = new MySqlCommand($"INSERT INTO {tableName} ({columns}) VALUES ({parameters})", connection))
    //        {
    //            foreach (var entry in columnValues)
    //            {
    //                cmd.Parameters.AddWithValue("@" + entry.Key, entry.Value);
    //            }

    //            await cmd.ExecuteNonQueryAsync();
    //        }
    //    });
    //}
}
