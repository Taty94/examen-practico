using Curso.Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Biblioteca.Dominio.Interfaces
{
    public interface IAutorRepositorio
    {
        /// <summary>
        /// Trae la consulta sin ejecutar de todos los registros de autores
        /// </summary>
        /// <returns></returns>
        IQueryable<Autor> GetAsync();

        /// <summary>
        /// Crear un nuevo objeto de tipo Autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        Task PostAsync(Autor autor);

        /// <summary>
        /// Modificar un objeto de tipo Autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        Task PutAsync(Autor autor);

        /// <summary>
        /// Eliminar un objeto de tipo Autor
        /// </summary>
        /// <param name="autor"></param>
        /// <returns></returns>
        Task DeleteAsync(Autor autor);

    }
}
