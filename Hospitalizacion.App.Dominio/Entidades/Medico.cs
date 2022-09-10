using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospitalizacion.App.Dominio
{
   public class Medico: PersonalSalud
   {
    public int Id {get; set; }

    [Required(ErrorMessage="este campo Especialidad es obligatorio")]
    public string Especialidad {get; set; }

    [Required(ErrorMessage="este campo Codigo es obligatorio")]
    public string Codigo {get; set; }

   
   //relacion con paciente 
    public List<Paciente> Paciente {get; set; }
   } 
}