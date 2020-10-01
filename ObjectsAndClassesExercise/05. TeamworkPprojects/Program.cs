using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace _05._TeamworkPprojects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            Team team = new Team();

            List<string> teamNames = new List<string>();
            List<string> teamUsers = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<String> input = Console.ReadLine().Split('-').ToList();
                team = new Team(input[0], input[1]);
                teamNames.Add(input[1]);
                teamUsers.Add(input[0]);

                bool wasCreated = false;
                bool cannotCreate = false;

                for (int j = 0; j < teams.Count; j++)
                {
                    if (input[1] == teamNames[j])
                    {
                        wasCreated = true;
                        Console.WriteLine($"Team {teams[j].TeamName} was already created!");
                    }

                    if (input[0] == teamUsers[j])
                    {
                        cannotCreate = true;
                        Console.WriteLine($"{teams[j].User} cannot create another team!");
                    }
                }
                if (wasCreated || cannotCreate)
                {
                    continue;
                }

                teams.Add(team);
                Console.WriteLine($"Team {team.TeamName} has been created by {team.User}!");
            }

            string line = Console.ReadLine();

            Team TeamJoin = new Team();
            while (line != "end of assignment")
            {
                string[] userTeam = line.Split("->").ToArray();
                bool exists = false;
                bool cantJoin = false;

                for (int i = 0; i < teams.Count; i++)
                {
                    if (userTeam[1] == teams[i].TeamName)
                    {
                        exists = true;
                        TeamJoin = new Team(userTeam[0], userTeam[1]);
                        teams.Add(TeamJoin);
                        break;
                    }

                    if (userTeam[0] == teams[i].User)
                    {
                        cantJoin = true;
                        Console.WriteLine($"Member {userTeam[0]} cannot join team {userTeam[1]} !");
                    }
                }

                if (!exists)
                {
                    Console.WriteLine($"Team {userTeam[1]} does not exist!");
                }
                if (!cantJoin)
                {
                    TeamJoin = new Team(userTeam[0], userTeam[1]);
                    teams.Add(TeamJoin);
                }

                line = Console.ReadLine();
            }

            ;
        }

    }

    class Team
    {
        public string User { get; set; }
        public string TeamName { get; set; }

        public Team()
        {

        }

        public Team(string user, string teamName)
        {
            this.User = user;
            this.TeamName = teamName;
        }
    }
}
