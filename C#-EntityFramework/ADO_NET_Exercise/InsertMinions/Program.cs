using System.Text;
using InsertMinions;
using Microsoft.Data.SqlClient;
//Read input
string[] minionArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] villainArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

string minionName = minionArgs[1];
int minionAge = int.Parse(minionArgs[2]);
string minionTown = minionArgs[3];
string villainName = villainArgs[1];

StringBuilder sb = new StringBuilder();

const string connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";

SqlConnection dbConnection = new SqlConnection(connectionString);
dbConnection.Open();
using (dbConnection)
{
    SqlTransaction sqlTransaction = dbConnection.BeginTransaction();
    try
    {
        int townId = await GetTownIdOrAddNameAsync(dbConnection, sqlTransaction, sb, minionTown);
        int villainId = await GetVillainOrAddVillainAsync(dbConnection, sqlTransaction, sb, villainName);
        int minionId = await InsertMinionAndGetId(dbConnection, sqlTransaction, sb, minionName, minionAge, townId);

        await SetMinionToBeServantOfVillainAsync(dbConnection, sqlTransaction, minionId, villainId);
        sb.AppendLine($"Successfully added {minionName} to be minion of {villainName}");
        await sqlTransaction.CommitAsync();
    }
    catch (Exception e)
    {
        await sqlTransaction.RollbackAsync();
        sb.AppendLine($"Transaction Failed!");
    }
}

Console.WriteLine(sb);


static async Task<int> GetTownIdOrAddNameAsync(SqlConnection sqlConnection, SqlTransaction sqlTransaction,
    StringBuilder sb, string townName)
{
    SqlCommand getTown = new SqlCommand(SqlQueries.SelectTownByName, sqlConnection, sqlTransaction);
    getTown.Parameters.AddWithValue("@townName", townName);

    int? townId = (int?)await getTown.ExecuteScalarAsync();
    if (!townId.HasValue)
    {
        SqlCommand addTownCommand = new SqlCommand(SqlQueries.InsertTown, sqlConnection, sqlTransaction);
        addTownCommand.Parameters.AddWithValue("@townName", townName);
        await addTownCommand.ExecuteNonQueryAsync();
        townId = (int?) await getTown.ExecuteScalarAsync();
        sb.AppendLine($"Town {townName} was added to the database");
    }

    return townId.Value;
}

static async Task<int> GetVillainOrAddVillainAsync(SqlConnection sqlConnection, SqlTransaction sqlTransaction,
    StringBuilder sb, string villainName)
{
    SqlCommand getVillain = new SqlCommand(SqlQueries.GetVillain, sqlConnection, sqlTransaction);
    getVillain.Parameters.AddWithValue("@Name", villainName);
    int? villainId = (int?)await getVillain.ExecuteScalarAsync();
    if (!villainId.HasValue)
    {
        SqlCommand insertVillain = new SqlCommand(SqlQueries.InsertVillain, sqlConnection, sqlTransaction);
        insertVillain.Parameters.AddWithValue("@Name", villainName);
        await insertVillain.ExecuteNonQueryAsync();
        villainId = (int?) await getVillain.ExecuteScalarAsync();
        sb.AppendLine($"Villain {villainName} was added to the database");
    }

    return villainId.Value;
}

static async Task<int> InsertMinionAndGetId(SqlConnection sqlConnection, SqlTransaction sqlTransaction, StringBuilder sb, string minionName, int minionAge, int townId)
{
    SqlCommand insertMinion = new SqlCommand(SqlQueries.InsertMinion, sqlConnection, sqlTransaction);
    insertMinion.Parameters.AddWithValue("@name", minionName);
    insertMinion.Parameters.AddWithValue("@age", minionAge);
    insertMinion.Parameters.AddWithValue("@townId", townId);

    await insertMinion.ExecuteNonQueryAsync();

    SqlCommand getMinionId = new SqlCommand(SqlQueries.GetMinionId, sqlConnection, sqlTransaction);
    getMinionId.Parameters.AddWithValue("@Name", minionName);
    int? minionId = (int?) await getMinionId.ExecuteScalarAsync();
    return minionId.Value;
}

static async Task SetMinionToBeServantOfVillainAsync(SqlConnection sqlConnection, SqlTransaction transaction, int minionId, int villainId)
{
    SqlCommand addMinionVillainCmd =
        new SqlCommand(SqlQueries.SetMinionToBeServantOfVillain, sqlConnection, transaction);
    addMinionVillainCmd.Parameters.AddWithValue("@minionId", minionId);
    addMinionVillainCmd.Parameters.AddWithValue("@villainId", villainId);

    await addMinionVillainCmd.ExecuteNonQueryAsync();
}