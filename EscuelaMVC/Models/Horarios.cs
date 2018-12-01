using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EscuelaMVC.Models
{
    public class Horarios
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(2,ErrorMessage ="El nombre de un horario tiene que ser mayor que 2")]
        [MaxLength(40,ErrorMessage ="El tamaño maximo para un horario tiene que ser menor que 40")]
        public string Nombre { get; set; }
        [MaxLength(100, ErrorMessage = "El tamaño maximo para un horario tiene que ser menor que 40")]
        [Required]
        [Display(Name = "Descripcion larga desde la anotacion")]
        public string DescripcionLarga { get; set; }

    }
}