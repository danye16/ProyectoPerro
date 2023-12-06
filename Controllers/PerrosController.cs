using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoPerro.Data.Services;
using ProyectoPerro.Data.ViewModels;

namespace ProyectoPerro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerrosController : ControllerBase
    {
        public PerrosService _perrosService;
        public PerrosController(PerrosService perrosService)
        {
            _perrosService = perrosService;
        }
        [HttpPost("add-perro")]
        public IActionResult AddBook([FromBody]PerroVM perro)
        {
            _perrosService.AddPerro(perro);
            return Ok();
        }

        //obetener todo los perros

        [HttpGet("get-all-perros")]
        public IActionResult GetAllPerros()
        {
            var allperros = _perrosService.GetAllPerros();
            return Ok(allperros);
        }
        //obtener perro por ID
        [HttpGet("get-perro-by-id/{id}*")]
        public IActionResult GetPerroById(int id)
        {
            var perro = _perrosService.GetPerroById(id);
            return Ok(perro);
        }
        //Editar un perro
        [HttpPut("update-perro-by-id/{id}")]
        public IActionResult UpdatePerroById(int id, [FromBody] PerroVM perro)
        {
            var updatePerro = _perrosService.UpdatePerroById(id, perro);
            return Ok(updatePerro);
        }
        //Eliminar un perro de la BD
        [HttpDelete("delete-perro-by-id/{id}")]
        public IActionResult DeletePerroById(int id)
        {
            _perrosService.DeletePerroById(id);
            return Ok();
        }
    }
}
