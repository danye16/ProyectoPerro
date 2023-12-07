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
        [HttpPost("add-update-collar")]
        public IActionResult AddorUpdateCollar([FromBody] CollarVM collar)
        {
            _collarsService.AddorUpdateCollar(collar);
            return Ok();
        }

        [HttpGet("get-all-collares")]
        public IActionResult GetAllCollars()
        {
            var allcollars = _collarsService.GetAllCollars();
            return Ok(allcollars);
        }
    }
}
