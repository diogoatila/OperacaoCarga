using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OperacaoCarga.Data;
using OperacaoCarga.Models;

namespace OperacaoCarga.Controllers
{
    public class ConteineresController : Controller
    {
        private readonly OperacaoCargaContext _context;

        public ConteineresController(OperacaoCargaContext context)
        {
            _context = context;
        }

        // GET: Conteineres
        public async Task<IActionResult> Index()
        {
            return View(await _context.Conteineres.ToListAsync());
        }

        // GET: Conteineres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conteiner = await _context.Conteineres
                .FirstOrDefaultAsync(m => m.ID == id);
            if (conteiner == null)
            {
                return NotFound();
            }

            return View(conteiner);
        }

        // GET: Conteineres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conteineres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Cliente,NumeroConteiner,TipoConteiner,StatusConteiner,CategoriaConteiner")] Conteiner conteiner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conteiner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(conteiner);
        }

        // GET: Conteineres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conteiner = await _context.Conteineres.FindAsync(id);
            if (conteiner == null)
            {
                return NotFound();
            }
            return View(conteiner);
        }

        // POST: Conteineres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Cliente,NumeroConteiner,TipoConteiner,StatusConteiner,CategoriaConteiner")] Conteiner conteiner)
        {
            if (id != conteiner.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conteiner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConteinerExists(conteiner.ID))
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
            return View(conteiner);
        }

        // GET: Conteineres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conteiner = await _context.Conteineres
                .FirstOrDefaultAsync(m => m.ID == id);
            if (conteiner == null)
            {
                return NotFound();
            }

            return View(conteiner);
        }

        // POST: Conteineres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conteiner = await _context.Conteineres.FindAsync(id);
            _context.Conteineres.Remove(conteiner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConteinerExists(int id)
        {
            return _context.Conteineres.Any(e => e.ID == id);
        }
    }
}
