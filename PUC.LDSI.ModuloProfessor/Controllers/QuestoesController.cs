using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;

namespace PUC.LDSI.ModuloProfessor.Controllers
{
    public class QuestoesController : Controller
    {
        private readonly AppDBContext _context;

        public QuestoesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Questoes
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.Questoes.Include(q => q.Avaliacao);
            return View(await appDBContext.ToListAsync());
        }

        // GET: Questoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _context.Questoes
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questao == null)
            {
                return NotFound();
            }

            return View(questao);
        }

        // GET: Questoes/Create
        public IActionResult Create()
        {
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id");
            return View();
        }

        // POST: Questoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AvaliacaoId,Tipo,Enunciado")] Questao questao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", questao.AvaliacaoId);
            return View(questao);
        }

        // GET: Questoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _context.Questoes.FindAsync(id);
            if (questao == null)
            {
                return NotFound();
            }
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", questao.AvaliacaoId);
            return View(questao);
        }

        // POST: Questoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AvaliacaoId,Tipo,Enunciado")] Questao questao)
        {
            if (id != questao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestaoExists(questao.Id))
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
            ViewData["AvaliacaoId"] = new SelectList(_context.Avaliacoes, "Id", "Id", questao.AvaliacaoId);
            return View(questao);
        }

        // GET: Questoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questao = await _context.Questoes
                .Include(q => q.Avaliacao)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (questao == null)
            {
                return NotFound();
            }

            return View(questao);
        }

        // POST: Questoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questao = await _context.Questoes.FindAsync(id);
            _context.Questoes.Remove(questao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestaoExists(int id)
        {
            return _context.Questoes.Any(e => e.Id == id);
        }
    }
}
