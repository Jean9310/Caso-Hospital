using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EliminarPacienteModel : PageModel
    {
         private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        public ActionResult OnGet(int id)
        {
            _repositorioPaciente.DeletePaciente(id);
            return RedirectToPage("./PacienteAdmin");
        }
    }
}
