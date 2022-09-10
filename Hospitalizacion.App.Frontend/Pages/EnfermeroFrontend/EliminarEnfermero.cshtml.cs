using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EliminarEnfermeroModel : PageModel
    {
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
        public Enfermero  Enfermero {get; set;}
        public ActionResult OnGet(int id)
        {
             _repositorioEnfermero.DeleteEnfermero(id);
            return RedirectToPage("./EnfermeroAdmin");
        }
    }
}
