using System.Text;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";

SqlConnection dbConnection = new SqlConnection(connectionString);
dbConnection.Open();
using (dbConnection)
{
    StringBuilder sb = new StringBuilder(); 
    string commandVillainsMinions = @"SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount  
                                    FROM Villains AS v 
                                    JOIN MinionsVillains AS mv ON v.Id = mv.VillainId 
                                GROUP BY v.Id, v.Name 
                                  HAVING COUNT(mv.VillainId) > 3 
                                ORDER BY COUNT(mv.VillainId)";
    SqlCommand minionsCommand = new SqlCommand(commandVillainsMinions, dbConnection);
    SqlDataReader dataReader = minionsCommand.ExecuteReader();
    while (dataReader.Read())
    {
        string name = (string)dataReader["Name"];
        int minionsCount = (int)dataReader["MinionsCount"];
        sb.AppendLine($"{name} - {minionsCount}");
    }

    Console.WriteLine(sb);
}