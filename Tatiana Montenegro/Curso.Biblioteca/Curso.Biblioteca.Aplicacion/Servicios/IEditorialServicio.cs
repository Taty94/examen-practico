using Curso.Biblioteca.Aplicacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Aplicacion.Servicios
{
    public interface IEditorialServicio
    {
        /// <summary>
        /// Obtener un coleccion de datos de tipo Editorial
        /// </summary>
        /// <returns></returns>
        Task<ICollection<EditorialDto>> GetAsync();

        /// <summary>
        /// Buscar por Identificar un solo objeto de tipo Editorial
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<EditorialDto> GetByIdAsync(int id);

        /// <summary>
        /// Crear un objeto de tipo Editorial
        /// </summary>
        /// <param name="editorialDto"></param>
        /// <returns></returns>
        Task<bool> PostAsync(CrearEditorialDto editorialDto);

        /// <summary>
        /// Modificar un objeto de tipo Editorial
        /// </summary>
        /// <param name="id"></param>
        /// <param name="editorialDto"></param>
        /// <returns></returns>
        Task<bool> PutAsync(int id, CrearEditorialDto editorialDto);

        /// <summary>
        /// Eliminar por Identificar un objeto de tipo Editorial
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(int id);
    }
}
