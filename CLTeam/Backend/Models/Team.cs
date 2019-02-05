using System.Collections.Generic;

namespace CLTeam.Backend.Models
{
    public class Team
    {
        public Team()
        {
            Players = new List<int>();
        }
        public string Name { get; set; }
        
        public List<int> Players { get; set; }
        
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Id {Id} Name {Name}";
        }
    }
}