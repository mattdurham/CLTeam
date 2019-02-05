using System;
using System.Runtime.InteropServices;
using CLTeam.Backend;
using CLTeam.Backend.Models;

namespace CLTeam.ConsoleUI
{
    public class MainLoop
    {
        // Underscores are often used to denote private variables in a class.
        //    this is NOT a hard rule and can vary between companies. I am using it here
        //    because it is the most common naming standard.
        CLTeamManager _manager;
        public MainLoop(CLTeamManager manager)
        {
            _manager = manager;
        }
        public void Run()
        {
            
            while (true)
            {
                PrintMainMenu();
                var option = Console.ReadLine();
                if (option == "1")
                {
                    RunAddRecord();
                }
                else if (option == "2")
                {
                    RunViewRecord();
                }
                else if (option == "3")
                {
                    var team = _manager.GetMostWinningTeam();
                    Console.WriteLine($"Team {team.Name} won!!!");
                }
                else if (option == "4")
                {
                    return;
                }
                else
                {
                    // The $ before a string means you are doing string formatting, the {option} is where
                    //    you want the variable option to appear at in the string.
                    Console.WriteLine($"Invalid Option {option} please try again");
                }
            }
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Add a Record");
            Console.WriteLine("2. View a Record");
            Console.WriteLine("3. See the winner!");
            Console.WriteLine("4. Exit");
        }

        private void RunAddRecord()
        {
            while (true)
            {
                PrintAddRecord();
                var option = Console.ReadLine();
                if (option == "1")
                {
                    AddPlayer();
                }
                else if (option == "2")
                {
                    AddTeam();
                }
                else if (option == "3")
                {
                    AddGame();
                }
                else if(option == "4")
                {
                    AddPlayerToTeamGame();
                }
                else if(option == "5")
                {
                    return;
                }
                else
                {
                    // The $ before a string means you are doing string formatting, the {option} is where
                    //    you want the variable option to appear at in the string.
                    Console.WriteLine($"Invalid Option {option} please try again");
                }
            }
        }

        private void PrintAddRecord()
        {
            Console.WriteLine("Add a record");
            Console.WriteLine("1. Add a Player");
            Console.WriteLine("2. Add a Team");
            Console.WriteLine("3. Add a Game");
            Console.WriteLine("4. Add a Player to a Team");
            Console.WriteLine("5. Return to Main Menu");
        }

        private void AddPlayer()
        {
            var player = new Player();
            Console.WriteLine("Enter a name");
            player.Name = Console.ReadLine();
            _manager.AddPlayer(player);
            Console.WriteLine($"Player {player} added");
        }

        private void AddTeam()
        {
            var team = new Team();
            Console.WriteLine("Enter a name");
            team.Name = Console.ReadLine();
            _manager.AddTeam(team);
            Console.WriteLine($"Team {team} added");
        }

        private void AddGame()
        {
            var game = new Game();
            
            Console.WriteLine("Enter Team1 ID");
            // This parse method converts a string to a integer
            var team1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Team2 ID");
            var team2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Team1 Score");
            // This parse method converts a string to a integer
            var team1score = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Team2 Score");
            var team2score = int.Parse(Console.ReadLine());

            game.Team1Id = team1;
            game.Team2Id = team2;
            game.Team1Score = team1score;
            game.Team2Score = team2score;

            _manager.AddGame(game);
            
            Console.WriteLine($"Game added");
        }
        
        private void AddPlayerToTeamGame()
        {
            
            
            Console.WriteLine("Enter Player ID");
            // This parse method converts a string to a integer
            var playerId = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Team ID");
            var teamId = int.Parse(Console.ReadLine());

            _manager.AddPlayerToTeam(playerId, teamId);
            
            Console.WriteLine($"Player added");
        }

        private void RunViewRecord()
        {
           
            while (true)
            {
                Console.WriteLine("View a record");
                Console.WriteLine("1. View a Player");
                Console.WriteLine("2. View a Team");
                Console.WriteLine("3. View a Game");
                Console.WriteLine("4. Return to Main Menu");

                var option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Enter a player id");
                    var id = int.Parse(Console.ReadLine());
                    var player = _manager.GetPlayer(id);
                    Console.WriteLine(player);
                }
                else if (option == "2")
                {
                    Console.WriteLine("Enter a team id");
                    var id = int.Parse(Console.ReadLine());
                    var team = _manager.GetTeam(id);
                    Console.WriteLine(team);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Enter a game id");
                    var id = int.Parse(Console.ReadLine());
                    var game = _manager.GetGame(id);
                    // Will leave has an exercise to the reader to show the team name instead of the team id
                    Console.WriteLine($"{game.Team1Id} scores {game.Team1Score} and {game.Team2Id} scored {game.Team2Score}");
                }
                else if(option == "4")
                {
                    return;
                }
                else
                {
                    // The $ before a string means you are doing string formatting, the {option} is where
                    //    you want the variable option to appear at in the string.
                    Console.WriteLine($"Invalid Option {option} please try again");
                }
            }
        }
    }
}