using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.Interfaces
{
    public interface ILibroRepositorio
    {
        /// <summary>
        /// Trae la consulta sin ejecutar de todos los registros de Libro
        /// </summary>
        /// <returns></returns>
        IQueryable<Libro> GetAsync();

        /// <summary>
        /// Crear un nuevo objeto de tipo Libro
        /// </summary>
        /// <param name="libro"></param>
        /// <returns></returns>
        Task PostAsync(Libro libro);

        /// <summary>
        /// Modificar un objeto de tipo Libro
        /// </summary>
        /// <param name="libro"></param>
        /// <returns></returns>
        Task PutAsync(Libro libro);

        /// <summary>
        /// Eliminar un objeto de tipo Libro
        /// </summary>
        /// <param name="libro"></param>
        /// <returns></returns>
        Task DeleteAsync(Libro libro);

    }
}
