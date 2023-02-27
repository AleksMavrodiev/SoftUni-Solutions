using System.Text;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";

SqlConnection dbConnection = new SqlConnection(connectionString);   
dbConnection.Open();
using (dbConnection)
{
    StringBuilder sb = new StringBuilder();
    int villainId = int.Parse(Console.ReadLine());
    string villainSearchQuery = @"SELECT Name FROM Villains WHERE Id = @Id";
    SqlCommand villainSearchCommand = new SqlCommand(villainSearchQuery, dbConnection);
    villainSearchCommand.Parameters.AddWithValue("@Id", villainId);
    object villainNameObj = await villainSearchCommand.ExecuteScalarAsync();
    if (villainNameObj == null)
    {
        Console.WriteLine($"No villain with ID {villainId} exists in the database.");
        Environment.Exit(0);
    }
    string villainName = (string)villainNameObj;

    sb.AppendLine($"Villain: {villainName}");

    string sqlSearchMinionsQuery = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) AS RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = @Id
                                ORDER BY m.Name";

    SqlCommand sqlSearchMinionsCommand = new SqlCommand(sqlSearchMinionsQuery, dbConnection);
    sqlSearchMinionsCommand.Parameters.AddWithValue("@Id", villainId);
    SqlDataReader dataReader = sqlSearchMinionsCommand.ExecuteReader();
    
    if (!dataReader.HasRows)
    {
        sb.AppendLine("(no minions)");
        Console.WriteLine(sb);
        Environment.Exit(0);
    }


    while (dataReader.Read())
    {
        sb.AppendLine($"{dataReader["RowNum"]}. {dataReader["Name"]} {dataReader["Age"]}");
    }

    Console.WriteLine(sb);
}