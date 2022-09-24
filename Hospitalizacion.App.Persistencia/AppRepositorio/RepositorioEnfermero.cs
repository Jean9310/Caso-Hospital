using System;
using System.Linq;
using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioEnfermero : IRepositorioEnfermero
    {
        // Conectar a la BDs
        private readonly AppContext _appContext;

        public RepositorioEnfermero(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Enfermero AddEnfermero(Enfermero enfermero)
        {
            
            var EnfermeroAdicionado = this._appContext.Enfermero.Add(enfermero);
           
            this._appContext.SaveChanges();

            return EnfermeroAdicionado.Entity;
        }

        public void DeleteEnfermero(int idEnfermero)
        {
           
            var EnfermeroAEliminar = 
                this._appContext.Enfermero
                    .FirstOrDefault( e => e.Id == idEnfermero);
            

            if ( EnfermeroAEliminar != null)
            {
                this._appContext.Enfermero.Remove(EnfermeroAEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Enfermero GetEnfermero(int idEnfermero)
        {
            return  
                this._appContext.Enfermero
                    .Where( e => e.Id == idEnfermero)
                    .SingleOrDefault<Enfermero>();
        }
        
        public IEnumerable<Enfermero> GetAllEnfermero()
        {
            
            return this._appContext.Enfermero;
        }

        public Enfermero UpdateEnfermero(Enfermero enfermero)
        {
            
            var EnfermeroEncontrado = 
                this._appContext.Enfermero
                    .FirstOrDefault( e => e.Id == enfermero.Id);
            if ( EnfermeroEncontrado != null )
            {
                EnfermeroEncontrado.Documento = enfermero.Documento;
                EnfermeroEncontrado.Nombre = enfermero.Nombre;
                EnfermeroEncontrado.Apellido = enfermero.Apellido;
                EnfermeroEncontrado.Telefono = enfermero.Telefono;
                EnfermeroEncontrado.Genero = enfermero.Genero;
                EnfermeroEncontrado.Registro = enfermero.Registro;
                EnfermeroEncontrado.TargetaProfesional = enfermero.TargetaProfesional;
                

                this._appContext.SaveChanges();
            }
            return  EnfermeroEncontrado;
        }



           public Enfermero GetEnfermeroXP(int idEnfermero) {
              return  
                this._appContext.Enfermero
                    .Where( e => e.Id == idEnfermero)
                    .SingleOrDefault<Enfermero>();
        }



        public Enfermero GetNombreDocumentoEnfermero(string dato1, string dato2)
        {
             return  this._appContext.Enfermero.Where( e => e.Nombre == dato1 && e.Telefono== dato2).SingleOrDefault<Enfermero>();  
        }
    }
}