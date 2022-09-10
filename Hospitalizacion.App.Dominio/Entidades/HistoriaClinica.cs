using System;

namespace Hospitalizacion.App.Dominio
{
   public class HistoriaClinica
   {
    public int Id {get; set; }
    public string Antecedentes{get; set; }
    public string Estado_Actual{get; set; }
    public DateTime Fecha{get;set;}

   //relacion con signos vitales
    public int SignosVitalesId {get; set; }
    public SignosVitales SignosVitales {get; set; }
   } 
}