using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    
    public class EliminarMedicoModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
        public Medico  Medico {get; set;}

        public ActionResult OnGet(int id)
        {
            _repositorioMedico.DeleteMedico(id);
            return RedirectToPage("./MedicoAdmin");
        }
    }
}
