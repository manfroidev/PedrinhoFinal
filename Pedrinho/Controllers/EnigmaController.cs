using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pedrinho.Models;

namespace Pedrinho.Controllers
{
    public class EnigmaController : Controller
    {
        private readonly PedrinhoContext _context;

        public EnigmaController(PedrinhoContext context)
        {
            _context = context;
        }

        // GET: Enigmata
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enigma.ToListAsync());
        }



   


        // GET: Enigmata/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enigma = await _context.Enigma
                .FirstOrDefaultAsync(m => m.id == id);
            if (enigma == null)
            {
                return NotFound();
            }

            return View(enigma);
        }

        // GET: Enigmata/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enigmata/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,resposta")] Enigma enigma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enigma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enigma);
        }





        // GET: Enigmata/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enigma = await _context.Enigma.FindAsync(id);
            if (enigma == null)
            {
                return NotFound();
            }
            return View(enigma);
        }

        // POST: Enigmata/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,resposta")] Enigma enigma)
        {
            if (id != enigma.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enigma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnigmaExists(enigma.id))
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
            return View(enigma);
        }

        // GET: Enigmata/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enigma = await _context.Enigma
                .FirstOrDefaultAsync(m => m.id == id);
            if (enigma == null)
            {
                return NotFound();
            }

            return View(enigma);
        }

        // POST: Enigmata/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enigma = await _context.Enigma.FindAsync(id);
            _context.Enigma.Remove(enigma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnigmaExists(int id)
        {
            return _context.Enigma.Any(e => e.id == id);
        }
    }
}
