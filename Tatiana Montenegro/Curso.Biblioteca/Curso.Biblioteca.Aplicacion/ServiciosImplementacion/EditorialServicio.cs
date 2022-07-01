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
    public class EditorialServicio : IEditorialServicio
    {
        private readonly IEditorialRepositorio _editorialRepositorio;

        public EditorialServicio(IEditorialRepositorio editorialRepositorio)
        {
            this._editorialRepositorio = editorialRepositorio;
        }

        public async Task<ICollection<EditorialDto>> GetAsync()
        {
            var consulta = _editorialRepositorio.GetAsync();
            var listaEditorial = await consulta.Select(e => new EditorialDto
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Direccion = e.Direccion,
            }).ToListAsync();

            return listaEditorial;
        }

        public async Task<EditorialDto> GetByIdAsync(int id)
        {
            var consulta = _editorialRepositorio.GetAsync();
            consulta = consulta.Where(e => e.Id == id);

            var editorial = await consulta.Select(e => new EditorialDto
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Direccion = e.Direccion
            }).SingleOrDefaultAsync();

            return editorial;
        }

        public async Task<bool> PostAsync(CrearEditorialDto autorDto)
        {
            var editorial = new Editorial()
            {
                Nombre = autorDto.Nombre,
                Direccion = autorDto.Direccion
            };

            await _editorialRepositorio.PostAsync(editorial);
            return true;
        }

        public async Task<bool> PutAsync(int id, CrearEditorialDto autorDto)
        {
            var consulta = _editorialRepositorio.GetAsync();
            consulta = consulta.Where(e => e.Id == id);

            var editorial = consulta.SingleOrDefault();
            editorial.Nombre = autorDto.Nombre;
            editorial.Direccion = autorDto.Direccion;

            await _editorialRepositorio.PutAsync(editorial);
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var consulta = _editorialRepositorio.GetAsync();
            consulta = consulta.Where(e => e.Id == id);

            var editorial = consulta.SingleOrDefault();
            await _editorialRepositorio.DeleteAsync(editorial);
            return true;
        }
    }
}
