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
    public class IndexModel : PageModel
    {
        private readonly CrudTest2.Data.ApplicationDbContext _context;

        public IndexModel(CrudTest2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Servico> Servico { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Servico = await _context.Servicos.ToListAsync();
        }
    }
}
