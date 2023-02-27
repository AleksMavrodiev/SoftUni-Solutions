using System.Text;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";

int villainId = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();

SqlConnection dbConnection = new SqlConnection(connectionString);
dbConnection.Open();
using (dbConnection)
{
    string selectVillainCommand = @"SELECT Name FROM Villains WHERE Id = @villainId";
    SqlCommand selectVillainToDelete = new SqlCommand(selectVillainCommand, dbConnection);
    selectVillainToDelete.Parameters.AddWithValue("@villainId", villainId);
    object nameObject = selectVillainToDelete.ExecuteScalar();
    if (nameObject == null)
    {
        sb.AppendLine("No such villain was found");
        Console.WriteLine(sb);
        Environment.Exit(0);
    }

    string deleteFromJoindeTableCommand = @"DELETE FROM MinionsVillains 
      WHERE VillainId = @villainId";

    SqlCommand deleteFromJoinedTable = new SqlCommand(deleteFromJoindeTableCommand, dbConnection);
    deleteFromJoinedTable.Parameters.AddWithValue("@villainId", villainId);
    
    int numberOfMinions = deleteFromJoinedTable.ExecuteNonQuery();

    string deleteVillainCommand = @"DELETE FROM Villains
      WHERE Id = @villainId";
    SqlCommand deleteVillain = new SqlCommand(deleteVillainCommand, dbConnection);
    deleteVillain.Parameters.AddWithValue("@villainId", deleteVillainCommand);

    Console.WriteLine("Number of minions were released");
}