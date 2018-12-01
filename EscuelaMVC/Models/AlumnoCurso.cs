using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscuelaMVC.Models
{
    public class AlumnoCurso
    {
        public Guid Id { get; set; }

        public Alumnos Alumno { get; set; }

        public Cursos Curso { get; set; }
    }
}