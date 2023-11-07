using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myper.BE.Models
{
    [Table("Departamento")]

    public class Departamento
    {
        public int Id { get; set; }
        public string? NombreDepartamento { get; set; }
    }
}
