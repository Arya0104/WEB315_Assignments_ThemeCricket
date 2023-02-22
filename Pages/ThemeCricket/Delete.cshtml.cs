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
    public class DeleteModel : PageModel
    {
        private readonly ThemeCricketContext _context;

        public DeleteModel(ThemeCricketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ThemeCricket ThemeCricket { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ThemeCricket = await _context.ThemeCricket.FirstOrDefaultAsync(m => m.ID == id);

            if (ThemeCricket == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ThemeCricket = await _context.ThemeCricket.FindAsync(id);

            if (ThemeCricket != null)
            {
                _context.ThemeCricket.Remove(ThemeCricket);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
