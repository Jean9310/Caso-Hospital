using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;


namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioSignosVitales : IRepositorioSignosVitales
    {
        private readonly Hospitalizacion.App.Persistencia.AppContext _appContext;

        public RepositorioSignosVitales(){}

        public RepositorioSignosVitales(Hospitalizacion.App.Persistencia.AppContext appContext)
        {
            this._appContext=appContext;
        }


        public SignosVitales AddSignosVitales(SignosVitales signosVitales)
        {
            var AdicionarSignos = this._appContext.SignosVitales.Add(signosVitales);
            this._appContext.SaveChanges();
            return AdicionarSignos.Entity;
        }

        public IEnumerable<SignosVitales> GetSignosVitalesXPaciente(int idPaciente)
        {
            return this._appContext.SignosVitales.Where(s => s.PacienteId ==idPaciente);
        }
       

         public SignosVitales GetSignosVitales(int idSignosVitales)
        {
            return  
                this._appContext.SignosVitales
                    .Where( s => s.Id == idSignosVitales)
                    .SingleOrDefault<SignosVitales>();
        }
    



    }
    
}