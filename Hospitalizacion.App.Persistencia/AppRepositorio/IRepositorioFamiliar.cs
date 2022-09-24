using System;

using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioFamiliar
    {
        Familiar AddFamiliar(Familiar familiar);  

        void DeleteFamiliar(int id);   // Firma del método

        Familiar GetFamiliar(int id);

        IEnumerable<Familiar> GetAllFamiliar();

        Familiar UpdateFamiliar(Familiar familiar);

        Familiar GetNombreDocumentoFamiliar(string dato1, string dato2);
    }
}