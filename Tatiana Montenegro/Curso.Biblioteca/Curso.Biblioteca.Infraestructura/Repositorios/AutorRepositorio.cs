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
    public class AutorRepositorio : IAutorRepositorio
    {
        private readonly BibliotecaDbContext _context;

        public AutorRepositorio(BibliotecaDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Autor> GetAsync()
        {
            return _context.Autor.AsQueryable();
        }

        public async Task PostAsync(Autor autor)
        {
            await _context.Autor.AddAsync(autor);
            await _context.SaveChangesAsync();
        }

        public async Task PutAsync(Autor autor)
        {
            _context.Autor.Update(autor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Autor autor)
        {
            _context.Autor.Remove(autor);
            await _context.SaveChangesAsync();
        }
    }
}
