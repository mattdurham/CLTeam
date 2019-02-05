using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using CLTeam.Backend.Models;
using Newtonsoft.Json;

namespace CLTeam.Backend
{
    public class CLTeamManager
    {
        DataStore _dataStore;

        public CLTeamManager()
        {
            LoadDataStore();
        }

        public IReadOnlyCollection<Player> Players
        {
            get { return _dataStore.Players.AsReadOnly(); }
        }
        
        public IReadOnlyCollection<Team> Teams
        {
            get { return _dataStore.Teams.AsReadOnly(); }
        }
        
        public IReadOnlyCollection<Game> Games
        {
            get { return _dataStore.Games.AsReadOnly(); }
        }
        
        public Player AddPlayer(Player player)
        {
            // The player id is just an incrementing id, in a normal database the database would increment.
            //    here we increment it ourselves. As an exercise to the reader, add a check to ensure that the id
            //    is actually unique. This could be done looping through the players to see if any existing ones have
            //    the same id
            player.Id = _dataStore.Players.Count + 1;
            _dataStore.Players.Add(player);
            SaveDataStore();
            return player;
        }
        
        public Team AddTeam(Team team)
        {
            team.Id = _dataStore.Teams.Count + 1;
            _dataStore.Teams.Add(team);
            SaveDataStore();
            return team;
        }

        public Game AddGame(Game game)
        {
            game.Id = _dataStore.Games.Count + 1;
            _dataStore.Games.Add(game);
            SaveDataStore();
            return game;
        }
        
        public int GetWinsForTeam(int id)
        {
            var wins = 0;
            foreach (var game in _dataStore.Games)
            {
                if (game.Team1Id == id && game.Team1Score > game.Team2Score)
                {
                    wins++;
                }
                else if (game.Team2Id == id && game.Team2Score > game.Team1Score)
                {
                    wins++;
                }
            }

            return wins;
        }

        public Player GetPlayer(int id)
        {
            // There are ways to optimize this by using a dictionary, will leave that has an exercise to the reader
            foreach (var player in _dataStore.Players)
            {
                if (player.Id == id)
                {
                    return player;
                }
            }

            // Nothing found so return nothing
            return null;
        }
        
        public Team GetTeam(int id)
        {
            // Using linq instead of foreach loop
            var resultList = ( from x in _dataStore.Teams
                where x.Id == id
                select x );
            // If there are no record return nothing
            if (resultList.Count() == 0)
            {
                return null;
            }

            return resultList.ElementAt(0);
        }

        public void AddPlayerToTeam(int playerid, int teamid)
        {
            var team = GetTeam(teamid);
            team.Players.Add(playerid);
            SaveDataStore();
        }
        
        public Game GetGame(int id)
        {
            // Using linq instead of foreach loop
            var resultList = ( from x in _dataStore.Games
                where x.Id == id
                select x );
            // If there are no record return nothing
            if (resultList.Count() == 0)
            {
                return null;
            }

            return resultList.ElementAt(0);

        }

        public Team GetMostWinningTeam()
        {
            var mostWins = -1;
            Team winningTeam = null;
            foreach (var team in _dataStore.Teams)
            {
                var teamWins = GetWinsForTeam(team.Id);
                if (teamWins > mostWins)
                {
                    mostWins = teamWins;
                    winningTeam = team;
                }
            }

            return winningTeam;
        }

        private void SaveDataStore()
        {
            var json = JsonConvert.SerializeObject(_dataStore);
            System.IO.File.WriteAllText("datastore.json", json);
        }

        private void LoadDataStore()
        {
            // On the first run this file may not exist, or maybe it was deleted
            if (System.IO.File.Exists("datastore.json"))
            {
                var json = System.IO.File.ReadAllText("datastore.json");
                _dataStore = JsonConvert.DeserializeObject<DataStore>(json);
                
                // All the follow code is to protect against bad data
                //    I want each list to at least be a list with 0 elements
                //    has opposed to a null list
                if (_dataStore.Games == null)
                {
                    _dataStore.Games = new List<Game>();
                }
                if (_dataStore.Teams == null)
                {
                    _dataStore.Teams = new List<Team>();
                }
                if (_dataStore.Players == null)
                {
                    _dataStore.Players = new List<Player>();
                }

                foreach (var team in _dataStore.Teams)
                {
                    if (team.Players == null)
                    {
                        team.Players = new List<int>();
                    }
                }
            }
            else
            {
                _dataStore = new DataStore();
            }
            
        }
    }
}