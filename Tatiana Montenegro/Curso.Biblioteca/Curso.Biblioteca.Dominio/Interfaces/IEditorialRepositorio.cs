using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.Interfaces
{
    public interface IEditorialRepositorio
    {
        /// <summary>
        /// Trae la consulta sin ejecutar de todos los registros de Editorial
        /// </summary>
        /// <returns></returns>
        IQueryable<Editorial> GetAsync();

        /// <summary>
        /// Crear un nuevo objeto de tipo Editorial
        /// </summary>
        /// <param name="editorial"></param>
        /// <returns></returns>
        Task PostAsync(Editorial editorial);

        /// <summary>
        /// Modificar un objeto de tipo Editorial
        /// </summary>
        /// <param name="editorial"></param>
        /// <returns></returns>
        Task PutAsync(Editorial editorial);

        /// <summary>
        /// Eliminar un objeto de tipo Editorial
        /// </summary>
        /// <param name="editorial"></param>
        /// <returns></returns>
        Task DeleteAsync(Editorial editorial);

    }
}
