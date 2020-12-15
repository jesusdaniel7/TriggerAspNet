using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tarea56.Data;
using Tarea56.Models;

namespace Tarea56.Controllers
{
    public class HistoricoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoricoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Historico
        public async Task<IActionResult> Index(string searchString)
        {
            @ViewData["CurrentFilter"] = searchString;

            var Historico = from s in _context.Historico select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                Historico = Historico.Where(s => s.H_Placa.Contains(searchString) || s.H_Cedula.Contains(searchString));
            }

            return View(await Historico.AsNoTracking().ToListAsync());
        }

        // GET: Historico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historico = await _context.Historico
                .FirstOrDefaultAsync(m => m.HistoricoID == id);
            if (historico == null)
            {
                return NotFound();
            }

            return View(historico);
        }
    }
}
