using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_3
{
    public class Member_Reyner
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
    class TeamMembers_2311104057
    {
        public List<Member_Reyner> members { get; set; }

        public void ReadJSON(string path)
        {
            string jsonData = File.ReadAllText(path);
            var team = JsonSerializer.Deserialize<TeamMembers_2311104057>(jsonData);

            Console.WriteLine("Team member list:");
            foreach (var member in team.members)
            {
                Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
            }
        }
    }
}
