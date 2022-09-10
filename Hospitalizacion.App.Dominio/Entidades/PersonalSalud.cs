using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospitalizacion.App.Dominio
{
    public class PersonalSalud: Persona
    {
        public int Id {get; set; }

        [Required(ErrorMessage="este campo Registro es obligatorio")]
        public string Registro {get; set; }

        [Required(ErrorMessage="este campo Targeta Profesional es obligatorio")]
        public string TargetaProfesional {get; set; }

    }
}