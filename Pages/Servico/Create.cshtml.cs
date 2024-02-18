using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudTest.Models;
using CrudTest2.Data;

namespace CrudTest2.Pages_Servico
{
    public class CreateModel : PageModel
    {
        private readonly CrudTest2.Data.ApplicationDbContext _context;

        public CreateModel(CrudTest2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Servico Servico { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Servicos.Add(Servico);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
