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
        [HttpPost("add-book-with-authors")]
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

    }
}
