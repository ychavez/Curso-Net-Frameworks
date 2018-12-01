using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaMVC.Models
{
    public class Alumnos
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
    }
}