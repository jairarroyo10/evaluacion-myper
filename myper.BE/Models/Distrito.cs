using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myper.BE.Models
{
    [Table("Distrito")]

    public class Distrito
    {
        public int Id { get; set; }
        public int? IdProvincia { get; set; }
        public string? NombreDistrito { get; set; }
    }
}
