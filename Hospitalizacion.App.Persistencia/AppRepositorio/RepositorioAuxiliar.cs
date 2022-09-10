using System;
using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        // Conectar a la BDs
        private readonly AppContext _appContext;

        public RepositorioAuxiliar(AppContext appContext)
        {
            this._appContext = appContext;
        }

        public Auxiliar AddAuxiliar(Auxiliar auxiliar)
        {
            // configuramos el ambiente para adicionar un usuario en la BDs
            var auxiliarAdicionado = this._appContext.Auxiliar.Add(auxiliar);
            //guarda la informacion del usuario en la BDs
            this._appContext.SaveChanges();

            return auxiliarAdicionado.Entity;
        }

        public void DeleteAuxiliar(int idAuxiliar)
        {
            // configurar el ambiente para buscar y eliminar el usuario
            var auxiliarAEliminar = 
                this._appContext.Auxiliar
                    .FirstOrDefault( a => a.Id == idAuxiliar);
            // select * from usuario u where u.id = idUsuario 

            if ( auxiliarAEliminar != null)
            {
                this._appContext.Auxiliar.Remove(auxiliarAEliminar);
                this._appContext.SaveChanges();
            }
        }

        public Auxiliar GetAuxiliar(int idAuxiliar)
        {
            return  
                this._appContext.Auxiliar
                    .Where( a => a.Id == idAuxiliar)
                    .SingleOrDefault<Auxiliar>();
        }
        
        public IEnumerable<Auxiliar> GetAllAuxiliar()
        {
            // select * from usuarios
            return this._appContext.Auxiliar;
        }

        public Auxiliar UpdateAuxiliar(Auxiliar auxiliar)
        {
            // Buscar usuario
            var auxiliarEncontrado = 
                this._appContext.Auxiliar
                    .FirstOrDefault( a => a.Id == auxiliar.Id);
            if ( auxiliarEncontrado != null )
            {
                auxiliarEncontrado.TipoAuxiliar = auxiliar.TipoAuxiliar;
                auxiliarEncontrado.Nombre = auxiliar.Nombre;
                auxiliarEncontrado.Apellido = auxiliar.Apellido;
                auxiliarEncontrado.Telefono = auxiliar.Telefono;
                auxiliarEncontrado.Genero = auxiliar.Genero;
                auxiliarEncontrado.Registro = auxiliar.Registro;
                auxiliarEncontrado.TargetaProfesional = auxiliar.TargetaProfesional;
                

                this._appContext.SaveChanges();
            }
            return auxiliarEncontrado;
        }
    }
}