using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoPerro.Data.Services;
using ProyectoPerro.Data.ViewModels;

namespace ProyectoPerro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private UsuariosService _usuariosService;

        public UsuariosController(UsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        [HttpPost("add-usuario")]
        public IActionResult AddUsuario([FromBody] UsuarioVM usuario)
        {
            _usuariosService.AddUsuario(usuario);
            return Ok();
        }

        [HttpGet("get-usuario-with-perros/{id}")]
        public IActionResult GetUsuarioData(int id)
        {
            var _response = _usuariosService.GetUsuarioData(id);
            return Ok(_response);
        }
    }
}
