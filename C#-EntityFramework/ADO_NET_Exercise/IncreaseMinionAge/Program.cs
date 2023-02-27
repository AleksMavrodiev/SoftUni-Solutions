using System.Text;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";

int[] minionIds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

SqlConnection dbConnection = new SqlConnection(connectionString);
dbConnection.Open();
using (dbConnection)
{
    for (int i = 0; i < minionIds.Length; i++)
    {
        string updateCommand = @" UPDATE Minions
                               SET Name = UPPER(LEFT(Name, 1)) + SUBSTRING(Name, 2, LEN(Name)), Age += 1
                                WHERE Id = @Id";
        SqlCommand updateMinions = new SqlCommand(updateCommand, dbConnection);
        updateMinions.Parameters.AddWithValue("@Id", minionIds[i]);
        await updateMinions.ExecuteNonQueryAsync();
    }

    SqlCommand selectMinions = new SqlCommand("SELECT Name, Age FROM Minions", dbConnection);
    SqlDataReader dataReader = selectMinions.ExecuteReader();
    using (dataReader)
    {
        while (dataReader.Read())
        {
            Console.WriteLine($"{dataReader["Name"]} {dataReader["Age"]}");
        }
    }
}