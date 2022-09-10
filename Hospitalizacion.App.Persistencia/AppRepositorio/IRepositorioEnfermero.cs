using System;

using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioEnfermero
    {
        Enfermero AddEnfermero(Enfermero enfermero);  

        void DeleteEnfermero(int id);   

        Enfermero GetEnfermero(int id);

        IEnumerable<Enfermero> GetAllEnfermero();

        Enfermero UpdateEnfermero(Enfermero enfermero);
    }
}