using System;

using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioSignosVitales
    {
        SignosVitales AddSignosVitales(SignosVitales signosVitales);  

        

        

        IEnumerable<SignosVitales> GetSignosVitalesXPaciente(int idPaciente);

       SignosVitales GetSignosVitales (int idSignosVitales);

        
    }
}