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
    public class AutorServicio : IAutorServicio
    {
        private readonly IAutorRepositorio _autorRepositorio;

        public AutorServicio(IAutorRepositorio autorRepositorio)
        {
            this._autorRepositorio = autorRepositorio;
        }

        public async Task<ICollection<AutorDto>> GetAsync()
        {
            var consulta = _autorRepositorio.GetAsync();
            var listaAutor = await consulta.Select(a => new AutorDto
            {
                Id = a.Id,
                Nombre = a.Nombre,
                Apellido = a.Apellido,
            }).ToListAsync();

            return listaAutor;
        }

        public async Task<AutorDto> GetByIdAsync(int id)
        {
            var consulta = _autorRepositorio.GetAsync();
            consulta = consulta.Where(a => a.Id == id);

            var autor = await consulta.Select(a => new AutorDto
            {
                Id = a.Id,
                Nombre = a.Nombre,
                Apellido = a.Apellido
            }).SingleOrDefaultAsync();

            return autor;
        }

        public async Task<bool> PostAsync(CrearAutorDto autorDto)
        {
            var autor = new Autor()
            {
                Nombre = autorDto.Nombre,
                Apellido = autorDto.Apellido
            };

            await _autorRepositorio.PostAsync(autor);
            return true;
        }

        public async Task<bool> PutAsync(int id, CrearAutorDto autorDto)
        {
            var consulta = _autorRepositorio.GetAsync();
            consulta = consulta.Where(a => a.Id == id);

            var autor = consulta.SingleOrDefault();
            autor.Nombre = autorDto.Nombre;
            autor.Apellido = autorDto.Apellido;

            await _autorRepositorio.PutAsync(autor);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var consulta = _autorRepositorio.GetAsync();
            consulta = consulta.Where(a => a.Id == id);

            var autor = consulta.SingleOrDefault();
            await _autorRepositorio.DeleteAsync(autor);
            return true;
        }
    }
}
