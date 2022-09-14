using System;
using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public  interface IRepositorioHistoriaClinica
    {
        HistoriaClinica AddHistoriaClinica(HistoriaClinica historiaClinica);

        void DeleteHistoriaClinica(int idHistoriaClinica);

        HistoriaClinica GetHistoriaClinica(int idHistoriaClinica);

        IEnumerable<HistoriaClinica> GetAllHistoriaClinica();   

        HistoriaClinica UpdateHistoriaClinica(HistoriaClinica historiaClinica);

        IEnumerable<HistoriaClinica> GetHistoriaXSigno(int idSignoVital);
    }
}