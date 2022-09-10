using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class PacienteAdminModel : PageModel
    {
         private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
          public IEnumerable<Paciente> Pac{get; set;}

        public PacienteAdminModel()
        {

        }

        public void OnGet()
        {
          this.Pac =_repositorioPaciente.GetAllPaciente();
        }
    }
    
}
