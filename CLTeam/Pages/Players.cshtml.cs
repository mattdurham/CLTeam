using CLTeam.Backend;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account.Manage;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLTeam.Pages
{
    public class Players : PageModel
    {
        CLTeamManager _manager;
        public Players(CLTeamManager manager)
        {
            _manager = manager;
        }
        
        public void OnGet()
        {
            this.ViewData["Players"] = _manager.Players;
        }
    }
}