using Curso.Biblioteca.Dominio.Entidades;
using Curso.Biblioteca.Dominio.Interfaces;
using Curso.Biblioteca.Infraestructura.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Infraestructura.Repositorios
{
    public class EditorialRepositorio : IEditorialRepositorio
    {
        private readonly BibliotecaDbContext _context;

        public EditorialRepositorio(BibliotecaDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Editorial> GetAsync()
        {
            return _context.Editorial.AsQueryable();
        }

        public async Task PostAsync(Editorial editorial)
        {
            await _context.Editorial.AddAsync(editorial);
            await _context.SaveChangesAsync();
        }

        public async Task PutAsync(Editorial editorial)
        {
            _context.Editorial.Update(editorial);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Editorial editorial)
        {
            _context.Editorial.Remove(editorial);
            await _context.SaveChangesAsync();
        }
    }
}
