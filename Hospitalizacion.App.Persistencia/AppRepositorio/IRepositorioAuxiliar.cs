using System;

using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        Auxiliar AddAuxiliar(Auxiliar auxiliar);  

        void DeleteAuxiliar(int id);   // Firma del método

        Auxiliar GetAuxiliar(int id);

        IEnumerable<Auxiliar> GetAllAuxiliar();

        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);
  
  
        Auxiliar GetAuxiliarXP(int id);
  
  
    }
}