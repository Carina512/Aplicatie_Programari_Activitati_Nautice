using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Aplicatie_Programari_Activitati_Nautice.Data;
using Aplicatie_Programari_Activitati_Nautice.models;

namespace Aplicatie_Programari_Activitati_Nautice.Pages.Activitati
{
    public class DetailsModel : PageModel
    {
        private readonly Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext _context;

        public DetailsModel(Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext context)
        {
            _context = context;
        }

      public Activitate Activitate { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Activitate == null)
            {
                return NotFound();
            }

            var activitate = await _context.Activitate.FirstOrDefaultAsync(m => m.ID == id);
            if (activitate == null)
            {
                return NotFound();
            }
            else 
            {
                Activitate = activitate;
            }
            return Page();
        }
    }
}
