using System;

namespace Hospitalizacion.App.Dominio
{
   public class PacienteFamiliar
   {
    public int Id{get; set; }
   
   
    public int FamiliarId {get; set; }
    public Familiar Familiar {get; set; }

    public int PacienteId {get; set; }
    public Paciente Paciente {get; set; }


   }
}