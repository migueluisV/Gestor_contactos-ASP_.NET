using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gestor_Contactos.Data;
using Gestor_Contactos.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Gestor_Contactos.Controllers
{
    public class ContactosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Contactos
        [Authorize]
        public IActionResult Index(String sortOrder)
        {
            // Recibe el valor para "sortOrder" según la opción seleccionada en la vista "Index".
            ViewData["NombreSortParm"] = String.IsNullOrEmpty(sortOrder) ? "Nombre_desc" : "";
            ViewData["ApellidoSortParm"] = sortOrder == "Apellido_asc" ? "Apellido_desc" : "Apellido_asc";

            // Obtiene los contactos del usuario loggeado actualmente.
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var ListaContactos = _context.Contactos.Where(e => e.Id_usuario == claims.Value);

            // Ordena los contactos según el parámetro "sortOrder".
            switch(sortOrder)
            {
                case "Nombre_asc":
                    ListaContactos = ListaContactos.OrderBy(c => c.Nombres);
                    break;
                case "Nombre_desc":
                    ListaContactos = ListaContactos.OrderByDescending(c => c.Nombres);
                    break;
                case "Apellido_asc":
                    ListaContactos = ListaContactos.OrderBy(c => c.Apellidos);
                    break;
                case "Apellido_desc":
                    ListaContactos = ListaContactos.OrderByDescending(c => c.Apellidos);
                    break;
                default:
                    ListaContactos = ListaContactos.OrderBy(c => c.Nombres);
                    break;
            }

            return View(ListaContactos.ToList());

            //return View(await _context.Contactos.Where(e => e.Id_usuario == claims.Value).ToListAsync());
        }

        // POST: Contactos/ResultadosBusqueda
        [Authorize]
        public async Task<IActionResult> ResultadosBusqueda(String FraseBuscar)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return View("Index", await _context.Contactos.Where(e => e.Id_usuario == claims.Value &&
                (e.Nombres.Contains(FraseBuscar) || e.Apellidos.Contains(FraseBuscar) || e.NumTel.Contains(FraseBuscar) ||
                e.Direccion.Contains(FraseBuscar) || e.Correo.Contains(FraseBuscar) || e.Notas.Contains(FraseBuscar))).ToListAsync());
        }

        // POST: Contactos/ResultadosPorGrupos
        [Authorize]
        public async Task<IActionResult> ResultadosPorGrupos(String FraseBuscar)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return View("Index", await _context.Contactos.Where(e => e.Id_usuario == claims.Value && e.Grupo == FraseBuscar).ToListAsync());
        }

        // GET: Contactos/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactos == null)
            {
                return NotFound();
            }

            return View(contactos);
        }

        // GET: Contactos/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contactos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_usuario,Favorito,Nombres,Apellidos,NumTel,Trabajo,Correo,Grupo,Direccion,Relacion,Notas,FechaCreacion")] Contactos contactos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactos);
        }

        // GET: Contactos/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos.FindAsync(id);
            if (contactos == null)
            {
                return NotFound();
            }
            return View(contactos);
        }

        // POST: Contactos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_usuario,Favorito,Nombres,Apellidos,NumTel,Trabajo,Correo,Grupo,Direccion,Relacion,Notas,FechaCreacion")] Contactos contactos)
        {
            if (id != contactos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactosExists(contactos.Id))
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
            return View(contactos);
        }

        // GET: Contactos/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactos == null)
            {
                return NotFound();
            }

            return View(contactos);
        }

        // POST: Contactos/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactos = await _context.Contactos.FindAsync(id);
            _context.Contactos.Remove(contactos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactosExists(int id)
        {
            return _context.Contactos.Any(e => e.Id == id);
        }
    }
}
