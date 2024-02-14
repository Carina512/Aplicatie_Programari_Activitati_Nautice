using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aplicatie_Programari_Activitati_Nautice.Data;
using Aplicatie_Programari_Activitati_Nautice.models;

namespace Aplicatie_Programari_Activitati_Nautice.Pages.Reviews
{
    public class DeleteModel : PageModel
    {
        private readonly Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext _context;

        public DeleteModel(Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Review Review { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FirstOrDefaultAsync(m => m.ID == id);

            if (review == null)
            {
                return NotFound();
            }
            else 
            {
                Review = review;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }
            var review = await _context.Review.FindAsync(id);

            if (review != null)
            {
                Review = review;
                _context.Review.Remove(Review);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
