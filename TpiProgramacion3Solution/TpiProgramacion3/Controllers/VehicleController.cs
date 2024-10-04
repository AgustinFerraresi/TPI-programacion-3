using Application.Interfaces;
using Domain.Classes;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost[("action")]]
        //en los parametros van los dto
        public IActionResult CreateVehicle([FromBody] CreateVehicleRequest request)
        {
            var result = _vehicleService.CreateVehicle(request);
            return Ok(result);
        }

        [HttpPost[("action")]]
        public IActionResult DeleteVehicle(Vehicle vehicle)
        {
            _vehicleService.DeleteVehicle(vehicle);
            return Ok("Vehiculo eliminado correctamente");
        }

        [HttpGet[("action")]]
        public IActionResult GetAllVehicles()
        {
            List<Vehicle> vehicles = _vehicleService.GetAllVehicles();
            return Ok(vehicles);            
        }

        [HttpGet]
        public IActionResult GetVehicleById([FromBody] int id)
        {
            Vehicle vehicle = _vehicleService.GetVehicleById(id);
            if (vehicle)
            {
                return Ok(vehicle);
            }

            return BadRequest(vehicle);
        }
    }
}
