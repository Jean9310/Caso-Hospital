using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class VerPacienteModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        public Paciente Paciente{get; set;}

        public VerPacienteModel(){}
        public ActionResult OnGet(int id)
        {
            this.Paciente=_repositorioPaciente.GetPaciente(id);
            return Page();
        }
    }
}
