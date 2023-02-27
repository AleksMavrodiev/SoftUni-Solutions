using System.Text;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";



SqlConnection dbConnection = new SqlConnection(connectionString);
dbConnection.Open();
using (dbConnection)
{
    SqlCommand selectALlminionNames = new SqlCommand(@"SELECT Name FROM Minions", dbConnection);
    SqlDataReader dataReader = selectALlminionNames.ExecuteReader();
    List<string> minionNames = new List<string>();
    using (dataReader)
    {
        while (dataReader.Read())
        {
            minionNames.Add((string)dataReader["Name"]);
        }
    }

    for (int i = 0; i < minionNames.Count / 2; i++)
    {
        Console.WriteLine(minionNames[i]);
        Console.WriteLine(minionNames[minionNames.Count - i - 1]);
    }
}