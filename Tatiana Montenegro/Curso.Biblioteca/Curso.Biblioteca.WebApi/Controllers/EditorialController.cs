using Curso.Biblioteca.Aplicacion.Dtos;
using Curso.Biblioteca.Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Curso.Biblioteca.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EditorialController : ControllerBase, IEditorialServicio
    {
        private readonly IEditorialServicio _editorialServicio;

        public EditorialController(IEditorialServicio editorialServicio)
        {
            this._editorialServicio = editorialServicio;
        }

        [HttpGet]
        public async Task<ICollection<EditorialDto>> GetAsync()
        {
            return await _editorialServicio.GetAsync();

        }

        [HttpGet("{id}")]
        public async Task<EditorialDto> GetByIdAsync(int id)
        {
            return await _editorialServicio.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<bool> PostAsync(CrearEditorialDto editorialDto)
        {
            return await _editorialServicio.PostAsync(editorialDto);

        }

        [HttpPut]
        public async Task<bool> PutAsync(int id, CrearEditorialDto editorialDto)
        {
            return await _editorialServicio.PutAsync(id, editorialDto);

        }

        [HttpDelete]
        public async Task<bool> DeleteAsync(int id)
        {
            return await _editorialServicio.DeleteAsync(id);

        }
    }
}
