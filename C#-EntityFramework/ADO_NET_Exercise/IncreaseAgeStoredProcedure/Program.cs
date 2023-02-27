using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";

int id = int.Parse(Console.ReadLine());

SqlConnection dbConnection = new SqlConnection(connectionString);
dbConnection.Open();
using (dbConnection)
{
    SqlCommand cmd = new SqlCommand("usp_GetOlder", dbConnection)
    {
        CommandType = CommandType.StoredProcedure
    };

    SqlParameter param1 = new SqlParameter()
    {
        ParameterName = "@Id",
        SqlDbType = SqlDbType.Int,
        Value = id,
        Direction = ParameterDirection.Input
    };

    cmd.Parameters.Add(param1);
    await cmd.ExecuteNonQueryAsync();

    SqlCommand selectCommand = new SqlCommand("SELECT Name, Age FROM Minions WHERE Id = @Id", dbConnection);
    selectCommand.Parameters.AddWithValue("@Id", id);
    SqlDataReader dataReader = selectCommand.ExecuteReader();
    using (dataReader)
    {
        while (dataReader.Read())
        {
            Console.WriteLine((string)dataReader["Name"] + dataReader["Age"]);
        }
    }
}