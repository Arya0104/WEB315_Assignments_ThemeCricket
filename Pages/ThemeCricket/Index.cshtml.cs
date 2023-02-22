using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB315_Assignments_ThemeCricket.Models;

namespace WEB315_Assignments_ThemeCricket.Pages_ThemeCricket
{
    public class IndexModel : PageModel
    {
        private readonly ThemeCricketContext _context;

        public IndexModel(ThemeCricketContext context)
        {
            _context = context;
        }

        public IList<ThemeCricket> ThemeCricket { get;set; }

        public async Task OnGetAsync()
        {
            ThemeCricket = await _context.ThemeCricket.ToListAsync();
        }
    }
}
