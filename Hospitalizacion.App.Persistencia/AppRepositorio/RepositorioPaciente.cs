using System;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
       
        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Paciente AddPaciente(Paciente paciente)
        {
          
            var PacienteAdicionado = this._appContext.Paciente.Add(paciente);
            
            this._appContext.SaveChanges();

            return PacienteAdicionado.Entity;
        }

        public void DeletePaciente(int idPaciente)
        {
          
            var PacienteAEliminar = 
                this._appContext.Paciente
                    .FirstOrDefault( p => p.Id == idPaciente);
            

            if ( PacienteAEliminar != null)
            {
                this._appContext.Paciente.Remove(PacienteAEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Paciente GetPaciente(int idPaciente)
        {
            return  
                this._appContext.Paciente
                    .Where( p => p.Id == idPaciente)
                    .SingleOrDefault<Paciente>();
        }
        
        public IEnumerable<Paciente> GetAllPaciente()
        {
            
            return this._appContext.Paciente;
        }

        public Paciente UpdatePaciente(Paciente paciente)
        {
            // Buscar usuario
            var PacienteEncontrado = 
                this._appContext.Paciente
                    .FirstOrDefault( p => p.Id == paciente.Id);
            if ( PacienteEncontrado != null )
            {
                PacienteEncontrado.Direccion = paciente.Direccion;
                PacienteEncontrado.Ciudad = paciente.Ciudad;
                PacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                PacienteEncontrado.Longitud = paciente.Longitud;
                PacienteEncontrado.Latitud = paciente.Latitud;
                PacienteEncontrado.Nombre = paciente.Nombre;
                PacienteEncontrado.Apellido = paciente.Apellido;
                PacienteEncontrado.Telefono = paciente.Telefono;
                PacienteEncontrado.Genero = paciente.Genero;
                PacienteEncontrado.AuxiliarId = paciente.AuxiliarId;
                PacienteEncontrado.EnfermeroId = paciente.EnfermeroId;
                PacienteEncontrado.MedicoId = paciente.MedicoId;
                

                this._appContext.SaveChanges();
            }
            return PacienteEncontrado;
        }








       
     

    



    }
    
}