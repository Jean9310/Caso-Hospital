using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hospitalizacion.App.Dominio
{
   public class Auxiliar: PersonalSalud 
   {
    public int Id {get; set; }

    [Required(ErrorMessage="este campo TipoAuxiliar es obligatorio")]
    public string TipoAuxiliar {get; set; }
    

   //relacion 1_n con paciente
  public List<Paciente> ListaPaciente {get; set; }
    
   }
}