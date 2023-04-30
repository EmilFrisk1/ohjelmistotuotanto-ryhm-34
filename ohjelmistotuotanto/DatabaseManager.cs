using System;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.ComponentModel;
using ohjelmistotuotanto;
using System.Globalization;
using Google.Protobuf.WellKnownTypes;

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

    public async Task<T> ExecuteWithRetry<T>(Func<MySqlConnection, Task<T>> operation)
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

                    T result = await operation(connection);

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
        return default(T);
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


    public async Task<int> AlterDataAsync(string tableName, Dictionary<string, object> columnValues, string condition)
    {
        int affectedRows = await ExecuteWithRetry(async (connection) =>
        {
            var setValues = string.Join(", ", columnValues.Keys.Select(key => $"{key} = @{key}"));

            var debugString = $"UPDATE {tableName} SET {setValues} WHERE {condition}";

            using (MySqlCommand cmd = new MySqlCommand($"UPDATE {tableName} SET {setValues} WHERE {condition}", connection))
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


    public async Task<DataTable> SelectDataAsync(string tableName, List<string> columnNames = null, string whereClause = "")
    {
        DataTable dataTable = new DataTable();

        return await ExecuteWithRetry(async (connection) =>
        {
            string columns = "*";

            if (columnNames != null && columnNames.Count > 0)
            {
                columns = string.Join(", ", columnNames);
            }

            string query = $"SELECT {columns} FROM {tableName}";

            if (!string.IsNullOrEmpty(whereClause))
            {
                query += $" WHERE {whereClause}";
            }

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    dataTable.Load(reader);
                }
            }
            return dataTable;
        });
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

    public async Task<int> CheckAvailabilityAndUpdateAsync(int reservationId, int cottageId, string startDate, string endDate)
    {
        int response = -1;

        reservationId = await ExecuteWithRetry(async (connection) =>
        {
            using (MySqlCommand cmd = new MySqlCommand("check_availability_and_update", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_reservation_id", reservationId);
                cmd.Parameters.AddWithValue("@p_cottage_id", cottageId);
                cmd.Parameters.AddWithValue("@p_start_date", startDate);
                cmd.Parameters.AddWithValue("@p_end_date", endDate);

                cmd.Parameters.Add(new MySqlParameter("@p_reservation_id_out", MySqlDbType.Int32));
                cmd.Parameters["@p_reservation_id_out"].Direction = ParameterDirection.Output;

                await cmd.ExecuteNonQueryAsync();

                response = (int)cmd.Parameters["@p_reservation_id_out"].Value;
                return response;
            }
        });

        return response;
    }

    public async Task<List<ReservationDetails>> GetReservationWithDetails()
    {
        List<ReservationDetails> reservationDetailsList = new List<ReservationDetails>();

        await ExecuteWithRetry(async (connection) =>
        {
            using (MySqlCommand cmd = new MySqlCommand("get_reservation_with_details", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        reservationDetailsList.Add(new ReservationDetails
                        {
                            Id = reader.GetInt32(0),
                            LoppuPvm = reader.GetDateTime("end_date"),
                            AloitusPvm = reader.GetDateTime("start_date"),
                            Email = reader.GetString("email"),
                            MökinNimi = reader.GetString("cottage_name")
                        });
                    }
                }
                return reservationDetailsList;
            }
        });

        return reservationDetailsList;
    }

    public async Task<int> CalculateReservationTotal(int reservationId)
    {
        int totalPrice = -1;
        return totalPrice = await ExecuteWithRetry(async (connection) =>
        {
            string getTotalPriceQuery = $"SELECT " +
            $"DATEDIFF(reservation.end_date, reservation.start_date) * cottage.price + COALESCE(SUM(service.price * reservation_service.quantity), 0) AS total_price" +
            $" FROM reservation" +
            $" JOIN cottage ON reservation.cottage_id = cottage.id" +
            $" LEFT JOIN reservation_service ON reservation.id = reservation_service.reservation_id" +
            $" LEFT JOIN service ON reservation_service.service_id = service.id" +
            $" WHERE reservation.id = @reservationId" +
            $" GROUP BY reservation_service.reservation_id;";
            using (MySqlCommand cmd = new MySqlCommand(getTotalPriceQuery, connection))
            {
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                object result = await cmd.ExecuteScalarAsync();
                return result != DBNull.Value ? Convert.ToInt32(result) : -1;
            }
        });
    }


    public async Task<DataTable> SearchDataAsync(string query)
    {
        DataTable dataTable = new DataTable();

        await ExecuteWithRetry(async (connection) =>
        {
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                     dataTable.Load(reader);
                }
            }
            return dataTable;
        });

        return dataTable;
    }


    public async Task<int> DeleteReservationAsync(int reservationId)
    {
        int affectedRows = -1;

        affectedRows = await ExecuteWithRetry(async (connection) =>
        {
            // First, delete the rows in the reservation_service table
            string deleteReservationServiceQuery = $"DELETE FROM reservation_service WHERE reservation_id = @reservationId";
            using (MySqlCommand cmd = new MySqlCommand(deleteReservationServiceQuery, connection))
            {
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                await cmd.ExecuteNonQueryAsync();
            }

            // Next, delete the row in the reservation table
            string deleteReservationQuery = $"DELETE FROM reservation WHERE id = @reservationId";
            using (MySqlCommand cmd = new MySqlCommand(deleteReservationQuery, connection))
            {
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                affectedRows = await cmd.ExecuteNonQueryAsync();
            }

            return affectedRows;
        });

        return affectedRows;
    }


    public async Task<int> DeleteDataAsync(string tableName, string whereClause)
    {
        int affectedRows = -1;

        affectedRows = await ExecuteWithRetry(async (connection) =>
        {
            string query = $"DELETE FROM {tableName}";

            if (string.IsNullOrEmpty(whereClause))
            {
                return -1;
            } else
            {
                query += $" WHERE {whereClause}";
            }

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                affectedRows = await cmd.ExecuteNonQueryAsync();
            }
            return affectedRows;
        });

        return affectedRows;
    }
    public async void CreateBill(int reservationId, string endDate)
    {
        try
        {
            // Update the reservation to indicate its not cancelable anymore
            Dictionary<string, object> reservationColumnValues = new Dictionary<string, object>
                        {
                            { "reservation_status", "ACTIVE" }
                        };
            var response = await VillageNewbies._dbManager.AlterDataAsync("reservation", reservationColumnValues, $"id = {reservationId}");

            var totalCost = await VillageNewbies._dbManager.CalculateReservationTotal(reservationId);
            if (totalCost == -1)
            {
                throw new Exception("Error occurred while inserting data into the database.");
            }
            else
            {
                // add 30 days to the last day of the reservation for due date
                string dueDate = DateTime.ParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).AddDays(30).ToString("yyyy-MM-dd");


                Dictionary<string, object> billColumnValues = new Dictionary<string, object>
                                {
                                    { "sum", totalCost },
                                    { "due_date", dueDate },
                                    { "status", "PENDING" },
                                    { "reservation_id", reservationId },
                                };

                int billInsRes = await VillageNewbies._dbManager.InsertDataAsync("bill", billColumnValues);
                if (billInsRes <= 0)
                {
                    throw new Exception("Error occurred while inserting data into the database.");
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Jokin meni pieleen laskun teossa. \n" + ex.Message);
        }
    }

}
