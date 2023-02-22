using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Stadiums { get; set; }
        [BindProperty(SupportsGet = true)]
        public string WorldCup { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> StadiumNameQuery = from s in _context.ThemeCricket
                                    orderby s.StadiumName
                                    select s.StadiumName;

            var Standings = from s in _context.ThemeCricket
                        select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Standings = Standings.Where(s => s.StadiumName.Contains(SearchString) || s.FirstMatch.Contains(SearchString) || s.City.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(WorldCup))
            {
                Standings = Standings.Where(x => x.StadiumName == WorldCup);
            }
            Stadiums = new SelectList(await StadiumNameQuery.Distinct().ToListAsync());
            ThemeCricket = await Standings.ToListAsync();
        }
    }
}
