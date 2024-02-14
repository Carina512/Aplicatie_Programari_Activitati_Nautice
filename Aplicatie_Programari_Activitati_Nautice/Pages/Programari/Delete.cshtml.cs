using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aplicatie_Programari_Activitati_Nautice.Data;
using Aplicatie_Programari_Activitati_Nautice.models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Aplicatie_Programari_Activitati_Nautice.Pages.Programari
{
    public class DeleteModel : PageModel
    {
        private readonly Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext _context;

        public DeleteModel(Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Programare Programare { get; set; } = default!;
        public List<SelectListItem> ActivitateList { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Programare == null)
            {
                return NotFound();
            }

            var programare = await _context.Programare.FirstOrDefaultAsync(m => m.ID == id);

            if (programare == null)
            {
                return NotFound();
            }
            else 
            {
                Programare = programare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Programare == null)
            {
                return NotFound();
            }
            var programare = await _context.Programare.FindAsync(id);

            if (programare != null)
            {
                Programare = programare;
                _context.Programare.Remove(Programare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
