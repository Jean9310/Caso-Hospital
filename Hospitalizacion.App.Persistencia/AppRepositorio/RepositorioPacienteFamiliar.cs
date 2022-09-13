using System;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioPacienteFamiliar : IRepositorioPacienteFamiliar
    {
       
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

        public bool DeletePacienteFamiliar(int idFamiliar, int idPaciente)
        {
            var eliminarPacienteFamiliar =
                this._appContext.PacienteFamiliar
                    .FirstOrDefault(pf => pf.FamiliarId == idFamiliar && pf.PacienteId == idPaciente );

            if (eliminarPacienteFamiliar != null)
            {
                try
                {
                    this._appContext.PacienteFamiliar.Remove(eliminarPacienteFamiliar);
                    this._appContext.SaveChanges();
                    return true;
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
            return false;
        }

        public PacienteFamiliar GetPacienteFamiliar(int idFamiliar, int idPaciente)
        {
            return
                this._appContext.PacienteFamiliar
                .Where(pf => pf.FamiliarId == idFamiliar && pf.PacienteId == idPaciente )
                .SingleOrDefault<PacienteFamiliar>();

        }
    }
    
}