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


        [HttpPut("update-usuario-by-id/{id}")]
        public IActionResult UpdateUsuarioById(int id, [FromBody] UsuarioVM usuario)
        {
            var updateUsuario = _usuariosService.UpdateUsuarioById(id, usuario);
            return Ok(updateUsuario);
        }
        [HttpDelete("delete-usuario-by-id/{id}")]
        public IActionResult DeleteUsuarioById(int id)
        {
            _usuariosService.DeleteUsuarioById(id);
            return Ok();
        }

        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            var allbooks = _usuariosService.GetAllUsers();
            return Ok(allbooks);
        }

    }
}
