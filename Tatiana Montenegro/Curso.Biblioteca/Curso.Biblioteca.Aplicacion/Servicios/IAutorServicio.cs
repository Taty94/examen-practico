using Curso.Biblioteca.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Servicios
{
    public interface IAutorServicio
    {
        /// <summary>
        /// Obtener un coleccion de datos de tipo Autor
        /// </summary>
        /// <returns></returns>
        Task<ICollection<AutorDto>> GetAsync();

        /// <summary>
        /// Buscar por Identificar un solo objeto de tipo Autor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<AutorDto> GetByIdAsync(int id);

        /// <summary>
        /// Crear un objeto de tipo Autor
        /// </summary>
        /// <param name="autorDto"></param>
        /// <returns></returns>
        Task<bool> PostAsync(CrearAutorDto autorDto);

        /// <summary>
        /// Modificar un objeto de tipo Autor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="autorDto"></param>
        /// <returns></returns>
        Task<bool> PutAsync(int id, CrearAutorDto autorDto);

        /// <summary>
        /// Eliminar por Identificar un objeto de tipo Autor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(int id);
    }
}
