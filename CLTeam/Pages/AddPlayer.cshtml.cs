using CLTeam.Backend;
using CLTeam.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLTeam.Pages
{
    public class AddPlayer : PageModel
    {
        CLTeamManager _manager;
        public AddPlayer(CLTeamManager manager)
        {
            _manager = manager;
        }
        public void OnGet()
        {
            
        }
        
        public IActionResult OnPost([FromForm] string name)
        {
            var player = new Player();
            player.Name = name;
            _manager.AddPlayer(player);
            return Redirect("~/Players");
        }
    }
}