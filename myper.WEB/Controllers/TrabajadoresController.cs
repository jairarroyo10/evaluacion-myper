using Microsoft.AspNetCore.Mvc;
using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;


namespace myper.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadoresController : ControllerBase
    {
        private readonly ITrabajadorService _trabajadorService;

        public TrabajadoresController(ITrabajadorService trabajadorService)
        {
            _trabajadorService = trabajadorService;
        }

        [HttpGet]
        public IEnumerable<Trabajador> GetAllTrabajadores()
        {
            return _trabajadorService.GetAllTrabajadores();
        }

        [HttpGet("{id}")]
        public ActionResult<Trabajador> GetTrabajadorById(int id)
        {
            var trabajador = _trabajadorService.GetTrabajadorById(id);
            if (trabajador == null)
            {
                return NotFound();
            }
            return trabajador;
        }

        [HttpPost]
        public ActionResult<Trabajador> CreateTrabajador(TrabajadorRequestDto trabajador)
        {
            var trabajadorNuevo = _trabajadorService.CreateTrabajador(trabajador);
            return Ok(trabajadorNuevo);
        }

        [HttpPut("{id}")]
        public ActionResult<Trabajador> UpdateTrabajador(int id, TrabajadorRequestDto trabajador)
        {
            return Ok(_trabajadorService.UpdateTrabajador(id, trabajador));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTrabajador(int id)
        {
            _trabajadorService.DeleteTrabajador(id);
            return NoContent();
        }
    }
}
