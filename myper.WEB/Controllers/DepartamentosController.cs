using Microsoft.AspNetCore.Mvc;
using myper.BE.Dtos.Request;
using myper.BE.Models;
using myper.BL.IServices;


namespace myper.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        private readonly IDepartamentoService _departamentoService;

        public DepartamentosController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        [HttpGet]
        public IEnumerable<Departamento> GetAllDepartamentos()
        {
            return _departamentoService.GetAllDepartamentos();
        }

        [HttpGet("{id}")]
        public ActionResult<Departamento> GetDepartamentoById(int id)
        {
            var departamento = _departamentoService.GetDepartamentoById(id);
            if (departamento == null)
            {
                return NotFound();
            }
            return departamento;
        }

        [HttpPost]
        public ActionResult<Departamento> CreateDepartamento(DepartamentoRequestDto departamento)
        {
            var departamentoNuevo = _departamentoService.CreateDepartamento(departamento);
            return Ok(departamentoNuevo);
        }

        [HttpPut("{id}")]
        public ActionResult<Departamento> UpdateDepartamento(int id, DepartamentoRequestDto departamento)
        {     
            return Ok(_departamentoService.UpdateDepartamento(id, departamento));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDepartamento(int id)
        {
            _departamentoService.DeleteDepartamento(id);
            return NoContent();
        }
    }
}
