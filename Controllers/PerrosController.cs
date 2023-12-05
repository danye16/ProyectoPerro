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
    }
}
