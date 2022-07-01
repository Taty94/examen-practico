using Curso.Biblioteca.Aplicacion.Dtos;
using Curso.Biblioteca.Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AutorController : ControllerBase, IAutorServicio
    {
        private readonly IAutorServicio _autorServicio;

        public AutorController(IAutorServicio autorServicio)
        {
            this._autorServicio = autorServicio;
        }

        [HttpGet]
        public async Task<ICollection<AutorDto>> GetAsync()
        {
            return await _autorServicio.GetAsync();

        }

        [HttpGet("{id}")]
        public async Task<AutorDto> GetByIdAsync(int id)
        {
            return await _autorServicio.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<bool> PostAsync(CrearAutorDto autorDto)
        {
            return await _autorServicio.PostAsync(autorDto);

        }

        [HttpPut]
        public async Task<bool> PutAsync(int id, CrearAutorDto autorDto)
        {
            return await _autorServicio.PutAsync(id, autorDto);

        }

        [HttpDelete]
        public async Task<bool> DeleteAsync(int id)
        {
            return await _autorServicio.DeleteAsync(id);

        }
    }
}
