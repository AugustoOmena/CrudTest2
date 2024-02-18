using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudTest.Models;
using CrudTest2.Data;

namespace CrudTest2.Pages_Servico
{
    public class DeleteModel : PageModel
    {
        private readonly CrudTest2.Data.ApplicationDbContext _context;

        public DeleteModel(CrudTest2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Servico Servico { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servico = await _context.Servicos.FirstOrDefaultAsync(m => m.Id == id);

            if (servico == null)
            {
                return NotFound();
            }
            else
            {
                Servico = servico;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servico = await _context.Servicos.FindAsync(id);
            if (servico != null)
            {
                Servico = servico;
                _context.Servicos.Remove(Servico);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
