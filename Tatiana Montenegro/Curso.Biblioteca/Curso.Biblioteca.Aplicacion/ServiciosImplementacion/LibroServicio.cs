using Curso.Biblioteca.Aplicacion.Dtos;
using Curso.Biblioteca.Aplicacion.Servicios;
using Curso.Biblioteca.Dominio.Entidades;
using Curso.Biblioteca.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.ServiciosImplementacion
{
    public class LibroServicio : ILibroServicio
    {
        private readonly ILibroRepositorio _libroRepositorio;

        public LibroServicio(ILibroRepositorio libroRepositorio)
        {
            this._libroRepositorio = libroRepositorio;
        }

        public async Task<ICollection<LibroDto>> GetAsync()
        {
            var consulta = _libroRepositorio.GetAsync();
            var listaEditorial = await consulta.Select(e => new LibroDto
            {
                Id = e.Id,
                Titulo = e.Titulo,
                ISBN = e.ISBN,
                Autor = $"{e.Autor.Nombre} {e.Autor.Nombre}",
                Editorial = e.Editorial.Nombre,
                DireccionEditorial = e.Editorial.Direccion
            }).ToListAsync();

            return listaEditorial;
        }

        public async Task<LibroDto> GetByIdAsync(int id)
        {
            var consulta = _libroRepositorio.GetAsync();
            consulta = consulta.Where(e => e.Id == id);

            var editorial = await consulta.Select(e => new LibroDto
            {
                Id = e.Id,
                Titulo = e.Titulo,
                ISBN = e.ISBN,
                Autor = $"{e.Autor.Nombre} {e.Autor.Nombre}",
                Editorial = e.Editorial.Nombre,
                DireccionEditorial = e.Editorial.Direccion
            }).SingleOrDefaultAsync();

            return editorial;
        }

        public async Task<bool> PostAsync(CrearLibroDto libroDto)
        {
            var editorial = new Libro()
            {
                Titulo = libroDto.Titulo,
                ISBN = libroDto.ISBN,
                AutorId = libroDto.AutorId,
                EditorialId = libroDto.EditorialId
            };

            await _libroRepositorio.PostAsync(editorial);
            return true;
        }

        public async Task<bool> PutAsync(int id, CrearLibroDto libroDto)
        {
            var consulta = _libroRepositorio.GetAsync();
            consulta = consulta.Where(e => e.Id == id);

            var editorial = consulta.SingleOrDefault();
            editorial.Titulo = libroDto.Titulo;
            editorial.ISBN = libroDto.ISBN;
            editorial.AutorId = libroDto.AutorId;
            editorial.EditorialId = libroDto.EditorialId;

            await _libroRepositorio.PutAsync(editorial);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var consulta = _libroRepositorio.GetAsync();
            consulta = consulta.Where(e => e.Id == id);

            var editorial = consulta.SingleOrDefault();
            await _libroRepositorio.DeleteAsync(editorial);
            return true;
        }
    }
}
