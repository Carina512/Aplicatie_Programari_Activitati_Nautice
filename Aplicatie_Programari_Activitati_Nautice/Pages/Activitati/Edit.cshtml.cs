using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aplicatie_Programari_Activitati_Nautice.Data;
using Aplicatie_Programari_Activitati_Nautice.models;

namespace Aplicatie_Programari_Activitati_Nautice.Pages.Activitati
{
    public class EditModel : PageModel
    {
        private readonly Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext _context;

        public EditModel(Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Activitate Activitate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Activitate == null)
            {
                return NotFound();
            }

            var activitate =  await _context.Activitate.FirstOrDefaultAsync(m => m.ID == id);
            if (activitate == null)
            {
                return NotFound();
            }
            Activitate = activitate;
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

            _context.Attach(Activitate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActivitateExists(Activitate.ID))
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

        private bool ActivitateExists(int id)
        {
          return (_context.Activitate?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
