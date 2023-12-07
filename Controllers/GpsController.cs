using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoPerro.Data.Services;
using ProyectoPerro.Data.ViewModels;

namespace ProyectoPerro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GpsController : ControllerBase
    {
        private GpsService _gpsService;
        public GpsController(GpsService gpsService)
        {
            _gpsService = gpsService;
        }
        [HttpPost("add-update-GPS")]
        public IActionResult AddOrUpdateGps([FromBody] GpsVM gps)
        {
            _gpsService.AddOrUpdateGps(gps);
            return Ok();
        }

        [HttpGet("get-all-GPS")]
        public IActionResult GetAllGPS()
        {
            var allgps = _gpsService.GetAllGPS();
            return Ok(allgps);
        }

        [HttpGet("get-gps-by-id/{id}*")]
        public IActionResult GetGPSById(int id)
        {
            var gps = _gpsService.GetGPSById(id);
            return Ok(gps);
        }
    }

   
}
