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
    public class DetailsModel : PageModel
    {
        private readonly CrudTest2.Data.ApplicationDbContext _context;

        public DetailsModel(CrudTest2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
