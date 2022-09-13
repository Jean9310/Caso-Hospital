using System;
using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public class RepositorioHistoriaClinica : IRepositorioHistoriaClinica
    {
        private readonly AppContext  _appContext;

        public RepositorioHistoriaClinica(AppContext appContext)
        {
            this._appContext = appContext;
        }
        public HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var historiaAdicionada = this._appContext.HistoriaClinica.Add(historiaClinica);
            this._appContext.SaveChanges();
            return historiaAdicionada.Entity;

        }

        public void DeleteHistoriaClinica(int idHistoriaClinica)
        {
            var HistoriaAEliminar = 
                this._appContext.HistoriaClinica
                    .FirstOrDefault( h => h.Id == idHistoriaClinica);
            

            if ( HistoriaAEliminar != null)
            {
                this._appContext.HistoriaClinica.Remove(HistoriaAEliminar);
                this._appContext.SaveChanges();
            }

        }

        public HistoriaClinica GetHistoriaClinica(int idHistoriaClinica)
        {
            return
                this._appContext.HistoriaClinica
                    .Where(h => h.Id == idHistoriaClinica)
                    .SingleOrDefault<HistoriaClinica>();
        }

        public IEnumerable<HistoriaClinica> GetAllHistoriaClinica()
        {
            return this._appContext.HistoriaClinica;     

        }

        public HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica)
        {
            var historiaEncontrada = 
                 this._appContext.HistoriaClinica.
                 FirstOrDefault(h => h.Id == historiaClinica.Id);
        
            if( historiaEncontrada != null )
            {
                historiaEncontrada.Antecedentes = historiaClinica.Antecedentes;
                historiaEncontrada.Estado_Actual = historiaClinica.Estado_Actual;
                historiaEncontrada.Fecha = historiaClinica.Fecha;

                this._appContext.SaveChanges();
            }
            return historiaEncontrada;

        }

        public IEnumerable<HistoriaClinica> GetHistoriaXSigno(int idSignoVital)
        {
            return
                this._appContext.HistoriaClinica
                    .Where (h => h.SignosVitalesId == idSignoVital);
        }
    }
}