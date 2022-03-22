using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._TeamWorkProjects
{
    class Team
    {
        public Team(string name, string owner)
        {
            this.Name = name;
            this.User = owner;
            this.Members = new List<string>();
        }
        public string Name { get; set; }
        public string User { get; set; }

        public List<string> Members { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < teamCount; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string owner = cmdArgs[0];
                string teamName = cmdArgs[1];
                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(x => x.User == owner))
                {
                    Console.WriteLine($"{owner} cannot create another team!");
                    continue;
                }
                Team newTeam = new Team(teamName, owner);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {owner}!");
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string member = cmdArgs[0];
                string teamToJoin = cmdArgs[1];
                if (!teams.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }
                if (!CheckMember(teams, member))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    continue;
                }
                Team searchedTeam = teams.FirstOrDefault(x => x.Name == teamToJoin);
                searchedTeam.Members.Add(member);
            }

            List<Team> validTeams = new List<Team>();
            List<Team> invalidTeams = new List<Team>();
            foreach (Team team in teams)
            {
                if (team.Members.Count > 0)
                {
                    validTeams.Add(team);
                }
                else
                {
                    invalidTeams.Add(team);
                }
            }
            validTeams = validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();
            invalidTeams = invalidTeams.OrderBy(x => x.Name).ToList();
            foreach (Team team in validTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.User}");
                team.Members = team.Members.OrderBy(x => x).ToList();
                foreach (string member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in invalidTeams)
            {
                Console.WriteLine(team.Name);
            }
        }

        static bool CheckMember(List<Team> teams, string member)
        {
            if (teams.Any(x => x.User == member))
            {
                return false;
            }
            if (teams.Any(x => x.Members.Contains(member)))
            {
                return false;
            }
            return true;
        }


    }
}
