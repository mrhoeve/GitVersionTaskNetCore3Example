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
    public class IndexModel : PageModel
    {
        private readonly TestCore3.Models.TestCore3Context _context;

        public IndexModel(TestCore3.Models.TestCore3Context context)
        {
            _context = context;
        }

        public IList<Model> Model { get;set; }

        public async Task OnGetAsync()
        {
            Model = await _context.Model.ToListAsync();
        }
    }
}
