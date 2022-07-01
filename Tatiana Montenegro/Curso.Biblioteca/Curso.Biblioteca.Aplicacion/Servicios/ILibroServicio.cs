using Curso.Biblioteca.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Servicios
{
    public interface ILibroServicio
    {
        /// <summary>
        /// Obtener un coleccion de datos de tipo Libro
        /// </summary>
        /// <returns></returns>
        Task<ICollection<LibroDto>> GetAsync();

        /// <summary>
        /// Buscar por Identificar un solo objeto de tipo Libro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<LibroDto> GetByIdAsync(int id);

        /// <summary>
        /// Crear un objeto de tipo Libro
        /// </summary>
        /// <param name="editorialDto"></param>
        /// <returns></returns>
        Task<bool> PostAsync(CrearLibroDto editorialDto);

        /// <summary>
        /// Modificar un objeto de tipo Libro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editorialDto"></param>
        /// <returns></returns>
        Task<bool> PutAsync(int id, CrearLibroDto editorialDto);

        /// <summary>
        /// Eliminar por Identificar un objeto de tipo Libro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(int id);
    }
}
