using Microsoft.AspNetCore.Mvc;
using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;


namespace myper.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritosController : ControllerBase
    {
        private readonly IDistritoService _distritoService;

        public DistritosController(IDistritoService distritoService)
        {
            _distritoService = distritoService;
        }

        [HttpGet]
        public IEnumerable<Distrito> GetAllDistritos()
        {
            return _distritoService.GetAllDistritos();
        }

        [HttpGet("{id}")]
        public ActionResult<Distrito> GetDistritoById(int id)
        {
            var distrito = _distritoService.GetDistritoById(id);
            if (distrito == null)
            {
                return NotFound();
            }
            return distrito;
        }

        [HttpPost]
        public ActionResult<Distrito> CreateDistrito(DistritoRequestDto distrito)
        {
            var distritoNuevo = _distritoService.CreateDistrito(distrito);
            return Ok(distritoNuevo);
        }

        [HttpPut("{id}")]
        public ActionResult<Distrito> UpdateDistrito(int id, DistritoRequestDto distrito)
        {
            return Ok(_distritoService.UpdateDistrito(id, distrito));

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDistrito(int id)
        {
            _distritoService.DeleteDistrito(id);
            return NoContent();
        }
    }
}
