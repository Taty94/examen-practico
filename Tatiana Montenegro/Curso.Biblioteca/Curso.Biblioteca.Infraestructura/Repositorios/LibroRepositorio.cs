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
    public class LibroRepositorio : ILibroRepositorio
    {
        private readonly BibliotecaDbContext _context;

        public LibroRepositorio(BibliotecaDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Libro> GetAsync()
        {
            return _context.Libro.AsQueryable();
        }

        public async Task PostAsync(Libro libro)
        {
            await _context.Libro.AddAsync(libro);
            await _context.SaveChangesAsync();
        }

        public async Task PutAsync(Libro libro)
        {
            _context.Libro.Update(libro);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Libro libro)
        {
            _context.Libro.Remove(libro);
            await _context.SaveChangesAsync();
        }
    }
}
