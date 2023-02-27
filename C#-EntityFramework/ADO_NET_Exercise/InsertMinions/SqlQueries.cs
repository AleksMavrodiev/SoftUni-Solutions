using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertMinions
{
    public static class SqlQueries
    {
        public const string SelectTownByName = @"SELECT Id FROM Towns WHERE Name = @townName";
        public const string InsertTown = @"INSERT INTO Towns (Name) VALUES (@townName)";
        public const string GetVillain = @"SELECT Id FROM Villains WHERE Name = @Name";
        public const string InsertVillain = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";
        public const string InsertMinion = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)";
        public const string GetMinionId = @"SELECT Id FROM Minions WHERE Name = @Name";

        public const string SetMinionToBeServantOfVillain =
            @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@minionId, @villainId)";
    }
}
