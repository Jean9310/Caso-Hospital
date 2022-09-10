using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class VerMedicoModel : PageModel
    {
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
        public Medico Medico{get; set;}

        public VerMedicoModel(){}
        public ActionResult OnGet(int id)
        {
            this.Medico=_repositorioMedico.GetMedico(id);
            return Page();
        }
    }
}
