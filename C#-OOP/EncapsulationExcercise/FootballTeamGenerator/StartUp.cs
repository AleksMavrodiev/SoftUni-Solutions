using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {


            List<Team> teams = new List<Team>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] cmdArgs = command.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    string action = cmdArgs[0];
                    string teamName = cmdArgs[1];
                    if (action == "Team")
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (action == "Add")
                    {
                        string playerName = cmdArgs[2];
                        int endurance = int.Parse(cmdArgs[3]);
                        int sprint = int.Parse(cmdArgs[4]);
                        int dribble = int.Parse(cmdArgs[5]);
                        int passing = int.Parse(cmdArgs[6]);
                        int shooting = int.Parse(cmdArgs[7]);
                        Team team = teams.FirstOrDefault(x => x.Name == teamName); 
                        if (team == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        Player player = new Player(playerName, endurance, sprint, dribble, shooting, passing);
                        team.AddPlayer(player);
                    }
                    else if (action == "Remove")
                    {
                        string playerName = cmdArgs[2];
                        Team team = teams.FirstOrDefault(x => x.Name == teamName);
                        if (team == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        team.RemovePlayer(playerName);
                    }
                    else if (action == "Rating")
                    {
                        Team team = teams.FirstOrDefault(x => x.Name == teamName);
                        if (team == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                        Console.WriteLine(team);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    
                }
            }

        }
    } 
}

