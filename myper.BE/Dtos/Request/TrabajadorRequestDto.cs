using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myper.BE.Dtos.Request
{
    public class TrabajadorRequestDto
    {
        public string? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Nombres { get; set; }
        public string? Sexo { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdDistrito { get; set; }
        public int? IdDepartamento { get; set; }
    }
}
