using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB315_Assignments_ThemeCricket.Models;

namespace WEB315_Assignments_ThemeCricket.Pages_ThemeCricket
{
    public class EditModel : PageModel
    {
        private readonly ThemeCricketContext _context;

        public EditModel(ThemeCricketContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ThemeCricket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThemeCricketExists(ThemeCricket.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ThemeCricketExists(int id)
        {
            return _context.ThemeCricket.Any(e => e.ID == id);
        }
    }
}
