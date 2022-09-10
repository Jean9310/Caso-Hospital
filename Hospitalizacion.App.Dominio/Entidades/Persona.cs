using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hospitalizacion.App.Dominio
{
    public class Persona
    {
        public int Id {get; set; }

        [Required(ErrorMessage="este campo Nombre es obligatorio")]
        public string Nombre {get; set; }

        [Required(ErrorMessage="este campo Apellido es obligatorio")]
        public string Apellido {get; set; }

        [Required(ErrorMessage="este campo Telefono es obligatorio")]
        public string Telefono {get; set; }

        [Required(ErrorMessage="este campo Genero es obligatorio")]
        public string Genero {get; set; }

    }
}


