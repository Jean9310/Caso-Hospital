using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hospitalizacion.App.Dominio
{
   public class Familiar:Persona
   {
    public int Id {get; set; }

    [Required(ErrorMessage="este campo Parentesco es obligatorio")]
    public string Parentesco {get; set; }

    [Required(ErrorMessage="este campo Correo Electronico es obligatorio")]
    public string Correo {get; set; }

   //relacion con paciente 
    public List<PacienteFamiliar> ListaPacienteFamilia {get; set; }
   } 
}