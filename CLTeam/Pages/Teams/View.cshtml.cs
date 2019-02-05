using System.Collections.Generic;
using System.Linq;
using CLTeam.Backend;
using CLTeam.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.IdentityModel.Tokens;

namespace CLTeam.Pages.Teams
{
    public class View : PageModel
    {
        CLTeamManager _manager;
        public View(CLTeamManager manager)
        {
            _manager = manager;
        }
        
        // This ensures on the post we get this back
        [BindProperty]
        public Team Team { get; set; }
        
        public List<Player> Players { get; set; }
        
        public List<Player> PlayersNotOnTeam { get; set; }
        
        public void OnGet(int id)
        {
            Team = _manager.GetTeam(id);
            var playerDictionary = new Dictionary<int, Player>();
            foreach (var playerId in Team.Players)
            {
                var player = _manager.GetPlayer(playerId);
                playerDictionary.Add(player.Id, player);
            } 

            Players = playerDictionary.Values.ToList();
            PlayersNotOnTeam = new List<Player>();

            // TODO what happens if the player already exists on another team?
            // we should not add those players to the players not on team object
            foreach (var player in _manager.Players)
            {
                if (playerDictionary.ContainsKey(player.Id) == false)
                {
                    PlayersNotOnTeam.Add(player);
                }
            }
        }

        public IActionResult OnPost([FromForm] string player)
        {
            // TODO what happens if the player already exists on another team?
            // add error messaging 
            var playerId = int.Parse(player);
            _manager.AddPlayerToTeam(playerId, Team.Id);
            return Redirect($"~/Teams/View/{Team.Id}");
        }
    }
}