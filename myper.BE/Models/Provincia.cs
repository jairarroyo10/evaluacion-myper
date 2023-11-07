using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myper.BE.Models
{
    [Table("Provincia")]

    public class Provincia
    {
        public int Id { get; set; }
        public int IdDepartamento { get; set; }
        public string? NombreProvincia { get; set; }
    }
}
