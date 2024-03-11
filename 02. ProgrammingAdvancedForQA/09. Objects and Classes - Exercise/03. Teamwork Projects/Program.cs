namespace _03._Teamwork_Projects
{
    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var countOfTeams = int.Parse(Console.ReadLine());
            var teams = new Dictionary<string, Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var input = Console.ReadLine().Split('-');
                var creator = input[0];
                var teamName = input[1];

                if (teams.ContainsKey(teamName)) 
                    Console.WriteLine($"Team {teamName} was already created!");
                else if (teams.Any(t => t.Value.Creator == creator)) 
                    Console.WriteLine($"{creator} cannot create another team!");
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(teamName, team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            var command = string.Empty;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                var input = command.Split("->");
                var user = input[0];
                var teamName = input[1];

                if (!teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                var userIsCreator = teams[teamName].Creator == user;
                var userAlreadyMember = teams.Values.Any(t => t.Members.Contains(user));

                if (userIsCreator || userAlreadyMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                teams[teamName].Members.Add(user);
            }

            var validTeams = teams
                .Where(t => t.Value.Members.Count > 0)
                .OrderBy(t => t.Value.Name)
                .ToDictionary(t => t.Key, t => t.Value);

            var emptyTeams = teams
                .Where(t => t.Value.Members.Count == 0)
                .OrderBy(t => t.Value.Name)
                .ToDictionary(t => t.Key, t => t.Value);

            foreach (var team in validTeams.Values.OrderByDescending(t => t.Members.Count))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var emptyTeam in emptyTeams.Values)
            {
                Console.WriteLine($"{emptyTeam.Name}");
            }
        }
    }
}