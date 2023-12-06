using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoPerro.Data.Services;
using ProyectoPerro.Data.ViewModels;

namespace ProyectoPerro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollarsController : ControllerBase
    {

        public CollarsService _collarsService;
        public CollarsController(CollarsService collarsService)
        {
            _collarsService = collarsService;
        }
        [HttpPost("add-collar")]
        public IActionResult AddCollar([FromBody] CollarVM collar)
        {
            _collarsService.AddCollar(collar);
            return Ok();
        }
    }
}
