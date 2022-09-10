using System;

namespace Hospitalizacion.App.Dominio
{
   public class SignosVitales
   {
    public int Id {get; set; }
    public string Oximetria {get; set; }
    public string FrecuenciaCardiaca{get;set;}
    public string FrecuenciaRespiratoria{get;set;}
    public string Temperatura{get;set;}
    public string PresionArteria{get;set;}
    public string Glicemias{get;set;}
    public  string Registro{get;set;}
    public DateTime Fecha{get;set;}

        
    //relacion con historia clinica
    public List<HistoriaClinica> ListaHistoriaClinica {get; set; }

    
   //relacion con paciente 
    public int PacienteId {get; set; }
    public Paciente Paciente {get; set; }




   }
}