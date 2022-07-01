using Curso.Biblioteca.Aplicacion.Dtos;
using Curso.Biblioteca.Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LibroController : ControllerBase, ILibroServicio
    {
        private readonly ILibroServicio _libroServicio;

        public LibroController(ILibroServicio libroServicio)
        {
            this._libroServicio = libroServicio;
        }

        [HttpGet]
        public async Task<ICollection<LibroDto>> GetAsync()
        {
            return await _libroServicio.GetAsync();

        }

        [HttpGet("{id}")]
        public async Task<LibroDto> GetByIdAsync(int id)
        {
            return await _libroServicio.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<bool> PostAsync(CrearLibroDto libroDto)
        {
            return await _libroServicio.PostAsync(libroDto);

        }

        [HttpPut]
        public async Task<bool> PutAsync(int id, CrearLibroDto libroDto)
        {
            return await _libroServicio.PutAsync(id, libroDto);

        }

        [HttpDelete]
        public async Task<bool> DeleteAsync(int id)
        {
            return await _libroServicio.DeleteAsync(id);

        }
    }
}
