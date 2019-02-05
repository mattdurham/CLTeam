using System.Collections.Generic;
using CLTeam.Backend.Models;

namespace CLTeam.Backend
{
    public class DataStore
    {
        // The new is so that the lists are never null references, they are always at least a list with 0 elements
        public List<Game> Games { get; set; } = new List<Game>();
        
        public List<Player> Players { get; set; } = new List<Player>();
        
        public List<Team> Teams { get; set; } = new List<Team>();
    }
}