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
    public class DetailsModel : PageModel
    {
        private readonly Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext _context;

        public DetailsModel(Aplicatie_Programari_Activitati_Nautice.Data.Aplicatie_Programari_Activitati_NauticeContext context)
        {
            _context = context;
        }

      public Programare Programare { get; set; } = default!;
        public List<SelectListItem> ActivitateList { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            ActivitateList = _context.Activitate
           .Select(d => new SelectListItem { Value = d.ID.ToString(), Text = d.Denumire })
           .ToList();
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
    }
}
