using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestCore3;
using TestCore3.Models;

namespace TestCore3.Pages.Models
{
    public class DeleteModel : PageModel
    {
        private readonly TestCore3.Models.TestCore3Context _context;

        public DeleteModel(TestCore3.Models.TestCore3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Model Model { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model = await _context.Model.FirstOrDefaultAsync(m => m.Naam == id);

            if (Model == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model = await _context.Model.FindAsync(id);

            if (Model != null)
            {
                _context.Model.Remove(Model);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
