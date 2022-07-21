using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using McvCrud.Data;
using McvCrud.Models;

namespace McvCrud.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly McvCrudContext _context;

        public CadastrosController(McvCrudContext context)
        {
            _context = context;
        }

        //Pesquisa
        

        // GET: Cadastros
        public async Task<IActionResult> Index(string Pesquisa = "")
        {
              return _context.Cadastro != null ? 
                          View(await _context.Cadastro.ToListAsync()) :
                          Problem("Entity set 'McvCrudContext.Cadastro'  is null.");

                var q = _context.Cadastro.AsQueryable();
            if (!string.IsNullOrEmpty(Pesquisa))
                q = q.Where(c => c.Name.Contains(Pesquisa));
            q = q.OrderBy(c => c.Name);

            return View(q.ToList());

        }

        
       
        // GET: Cadastros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // GET: Cadastros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cadastros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Estado,Cidade,Rua,Numero,Referencia,Descricao,CEP")] Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastro);
        }

        // GET: Cadastros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro.FindAsync(id);
            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }

        // POST: Cadastros/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Estado,Cidade,Rua,Numero,Referencia,Descricao,CEP")] Cadastro cadastro)
        {
            if (id != cadastro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroExists(cadastro.Id))
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
            return View(cadastro);
        }

        // GET: Cadastros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cadastro == null)
            {
                return NotFound();
            }

            var cadastro = await _context.Cadastro
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        // POST: Cadastros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cadastro == null)
            {
                return Problem("Entity set 'McvCrudContext.Cadastro'  is null.");
            }
            var cadastro = await _context.Cadastro.FindAsync(id);
            if (cadastro != null)
            {
                _context.Cadastro.Remove(cadastro);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroExists(int id)
        {
          return (_context.Cadastro?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
