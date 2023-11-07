using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;

namespace myper.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciasController : ControllerBase
    {
        private readonly IProvinciaService _provinciaService;

        public ProvinciasController(IProvinciaService provinciaService)
        {
            _provinciaService = provinciaService;
        }

        [HttpGet]
        public IEnumerable<Provincia> GetAllProvincias()
        {
            return _provinciaService.GetAllProvincias();
        }

        [HttpGet("{id}")]
        public ActionResult<Provincia> GetProvinciaById(int id)
        {
            var provincia = _provinciaService.GetProvinciaById(id);
            if (provincia == null)
            {
                return NotFound();
            }
            return provincia;
        }

        [HttpPost]
        public ActionResult<Provincia> CreateProvincia(ProvinciaRequestDto provincia)
        {
            return Ok(_provinciaService.CreateProvincia(provincia));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProvincia(int id, ProvinciaRequestDto provincia)
        {

            return Ok(_provinciaService.UpdateProvincia(id, provincia));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProvincia(int id)
        {
            _provinciaService.DeleteProvincia(id);
            return NoContent();
        }
    }
}
