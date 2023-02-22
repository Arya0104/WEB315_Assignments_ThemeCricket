using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB315_Assignments_ThemeCricket.Models;

namespace WEB315_Assignments_ThemeCricket.Pages_ThemeCricket
{
    public class CreateModel : PageModel
    {
        private readonly ThemeCricketContext _context;

        public CreateModel(ThemeCricketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ThemeCricket ThemeCricket { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ThemeCricket.Add(ThemeCricket);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
