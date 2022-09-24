using System;
using System.Linq;
using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        // Conectar a la BDs
        private readonly AppContext _appContext;

        public RepositorioFamiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Familiar AddFamiliar(Familiar familiar)
        {
            // configuramos el ambiente para adicionar un usuario en la BDs
            var familiarAdicionado = this._appContext.Familiar.Add(familiar);
            //guarda la informacion del usuario en la BDs
            this._appContext.SaveChanges();

            return familiarAdicionado.Entity;
        }

        public void DeleteFamiliar(int idFamiliar)
        {
            // configurar el ambiente para buscar y eliminar el usuario
            var familiarAEliminar = 
                this._appContext.Familiar
                    .FirstOrDefault( f => f.Id == idFamiliar);
            // select * from usuario u where u.id = idUsuario 

            if ( familiarAEliminar != null)
            {
                this._appContext.Familiar.Remove(familiarAEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Familiar GetFamiliar(int idFamiliar)
        {
            return  
                this._appContext.Familiar
                    .Where( f => f.Id == idFamiliar)
                    .SingleOrDefault<Familiar>();
        }
        
        public IEnumerable<Familiar> GetAllFamiliar()
        {
            // select * from usuarios
            return this._appContext.Familiar;
        }

        public Familiar UpdateFamiliar(Familiar familiar)
        {
            // Buscar usuario
            var FamiliarEncontrado = 
                this._appContext.Familiar
                    .FirstOrDefault( f => f.Id == familiar.Id);
            if ( FamiliarEncontrado != null )
            {
                FamiliarEncontrado.Parentesco = familiar.Parentesco;
                FamiliarEncontrado.Correo = familiar.Correo;
                FamiliarEncontrado.Apellido =familiar.Apellido;
                FamiliarEncontrado.Genero=familiar.Genero;
                FamiliarEncontrado.Nombre=familiar.Nombre;
                FamiliarEncontrado.Telefono=familiar.Telefono;
            
                this._appContext.SaveChanges();
            }
            return FamiliarEncontrado;
        }


        public Familiar GetNombreDocumentoFamiliar(string dato1, string dato2)
        {
            return  this._appContext.Familiar.Where( f => f.Nombre == dato1 && f.Telefono== dato2).SingleOrDefault<Familiar>();  
        }



      





    }
}