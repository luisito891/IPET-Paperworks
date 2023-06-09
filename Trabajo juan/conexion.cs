using MySql.Data.MySqlClient;

string connectionString = "server=localhost;user=root;password=;database=horarios;";
using (MySqlConnection connection = new MySqlConnection(connectionString))
{
    connection.Open();
    string query = "SELECT * FROM divisiones";
    using (MySqlCommand command = new MySqlCommand(query, connection))
    {
        using (MySqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
            // Procesar los datos leídos
            }
        }
    }
}
