using System.Text;
using Microsoft.Data.SqlClient;

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";

string countryName = Console.ReadLine();

SqlConnection dbConnection = new SqlConnection(connectionString);
dbConnection.Open();
using (dbConnection)
{
    string updateCommand = @"UPDATE Towns
                               SET Name = UPPER(Name)
                             WHERE CountryCode = (SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName)";
    SqlCommand updateTown = new SqlCommand(updateCommand, dbConnection);
    updateTown.Parameters.AddWithValue("@countryName", countryName);
    updateTown.ExecuteNonQuery();
    
    //See changes
    string selectTownsCommand = @"SELECT t.Name 
                                   FROM Towns as t
                                   JOIN Countries AS c ON c.Id = t.CountryCode
                                  WHERE c.Name = @countryName";
    SqlCommand getChanges = new SqlCommand(selectTownsCommand, dbConnection);
    getChanges.Parameters.AddWithValue("@countryName", countryName);

    List<string>cities = new List<string>();

    SqlDataReader dataReader = getChanges.ExecuteReader();
    while (dataReader.Read())
    {
        cities.Add((string)dataReader["Name"]);
    }

    if (cities.Count == 0)
    {
        Console.WriteLine("No town names were affected.");
    }
    else
    {
        Console.WriteLine($"{cities.Count} town names were affected. ");
        Console.WriteLine($"{string.Join(", ", cities)}");
    }
}