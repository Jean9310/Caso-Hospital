using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class AsignarPersonalModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        public IEnumerable<Paciente> Paci{get; set;}
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        public IEnumerable<Familiar> Fam{get; set;}
        //private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        public AsignarPersonalModel(){}
        public void OnGet()
        {
            this.Paci =_repositorioPaciente.GetAllPaciente();
            this.Fam =_repositorioFamiliar.GetAllFamiliar();
        }
    }
}
