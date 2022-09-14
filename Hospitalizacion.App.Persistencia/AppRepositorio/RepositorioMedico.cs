using System;
using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        
        private readonly AppContext _appContext;

        public RepositorioMedico(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Medico AddMedico(Medico medico)
        {
            
            var MedicoAdicionado = this._appContext.Medico.Add(medico);
            
            this._appContext.SaveChanges();

            return MedicoAdicionado.Entity;
        }

        public void DeleteMedico(int idMedico)
        {
            
            var MedicoAEliminar = 
                this._appContext.Medico
                    .FirstOrDefault( m => m.Id == idMedico);
            

            if ( MedicoAEliminar != null)
            {
                this._appContext.Medico.Remove(MedicoAEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Medico GetMedico(int idMedico)
        {
            return  
                this._appContext.Medico
                    .Where( m => m.Id == idMedico)
                    .SingleOrDefault<Medico>();
        }
        
        public IEnumerable<Medico> GetAllMedico()
        {
            
            return this._appContext.Medico;
        }

        public Medico UpdateMedico(Medico medico)
        {
            
            var MedicoEncontrado = 
                this._appContext.Medico
                    .FirstOrDefault( m => m.Id == medico.Id);
            if ( MedicoEncontrado != null )
            {
                MedicoEncontrado.Especialidad = medico.Especialidad;
                MedicoEncontrado.Codigo = medico.Codigo;
                MedicoEncontrado.Nombre = medico.Nombre;
                MedicoEncontrado.Apellido = medico.Apellido;
                MedicoEncontrado.Telefono = medico.Telefono;
                MedicoEncontrado.Genero = medico.Genero;
                MedicoEncontrado.Registro = medico.Registro;
                MedicoEncontrado.TargetaProfesional = medico.TargetaProfesional;
                

                this._appContext.SaveChanges();
            }
            return MedicoEncontrado;
        }


        public Medico GetMedicoXP(int idMedico) {
              return  
                this._appContext.Medico
                    .Where( m => m.Id == idMedico)
                    .SingleOrDefault<Medico>();
        }



     public IEnumerable<Paciente> GetOacienteParaMedico(int idMedico)
        {
            return this._appContext.Paciente.Where(p => p.MedicoId ==idMedico);
        }




    }
}