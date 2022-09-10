using System;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioPacienteFamiliar : IRepositorioPacienteFamiliar
    {
       /*
        private readonly AppContext _appContext;

        public RepositorioPacienteFamiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public PacienteFamiliar AddPacienteFamiliar(PacienteFamiliar pacienteFamiliar)
        {
            var asignarPacienteFamiliar = this._appContext.PacienteFamiliar.Add(pacienteFamiliar);
            this._appContext.SaveChanges();
            return asignarPacienteFamiliar.Entity;
        }

        public IEnumerable<PacienteFamiliar>obtenerFamiliarXPaciente(int IdPaciente)
        {
            return this._appContext.PacienteFamiliar.Where (f => f.PacienteId ==IdPaciente);
        }
*/
       
    }
    
}