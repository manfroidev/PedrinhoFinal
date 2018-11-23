using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pedrinho.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Pedrinho.Controllers
{
    public class ContatoController : Controller
    {
        private readonly PedrinhoContext _context;

        public ContatoController(PedrinhoContext context)
        {
            _context = context;
        }

        // GET: contatoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contato.ToListAsync());
        }

        // GET: contatoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contato
                .FirstOrDefaultAsync(m => m.contatoId == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        // GET: contatoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: contatoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("contatoId,nome,descricao,usuarioId")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // GET: contatoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contato.FindAsync(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        // POST: contatoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("contatoId,nome,descricao,usuarioId")] Contato contato)
        {
            if (id != contato.contatoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!contatoExists(contato.contatoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        // GET: contatoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato = await _context.Contato
                .FirstOrDefaultAsync(m => m.contatoId == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }

        // POST: contatoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contato = await _context.Contato.FindAsync(id);
            _context.Contato.Remove(contato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool contatoExists(int id)
        {
            return _context.Contato.Any(e => e.contatoId == id);
        }
    }
}
