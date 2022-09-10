using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hospitalizacion.App.Dominio
{
   public class Enfermero: PersonalSalud
   {
    public int Id {get; set; }

    [Required(ErrorMessage="este campo Documento es obligatorio")]
    public string Documento {get; set; }

    
    //relacion con paciente 
    public List<Enfermero> ListaEnfermero {get; set; }
    
   } 
}