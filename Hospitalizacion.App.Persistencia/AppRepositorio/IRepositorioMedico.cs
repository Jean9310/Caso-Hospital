using System;

using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioMedico
    {
        Medico AddMedico(Medico medico);  

        void DeleteMedico(int id);   // Firma del método

       Medico GetMedico(int id);

        IEnumerable<Medico> GetAllMedico();

        Medico UpdateMedico(Medico medico);

        
    }
}