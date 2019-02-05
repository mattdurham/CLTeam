using System.Collections.Generic;
using CLTeam.Backend;
using CLTeam.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CLTeam.Pages.Teams
{
    public class IndexModel : PageModel
    {
        CLTeamManager _manager;
        public IndexModel(CLTeamManager manager)
        {
            _manager = manager;
        }

        // Instead of using the viewdata dictionary we can express it has a property on the page
        
        public IReadOnlyCollection<Team> TeamsList
        {
            get { return _manager.Teams; }
        }
        
        public void OnGet()
        {
                       
        }
    }
}