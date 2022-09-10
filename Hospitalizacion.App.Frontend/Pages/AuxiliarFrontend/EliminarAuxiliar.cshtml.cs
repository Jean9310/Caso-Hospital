using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EliminarAuxiliarModel : PageModel
    {
         private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
        public Auxiliar  Auxiliar {get; set;}
        public ActionResult OnGet(int id)
        {
             _repositorioAuxiliar.DeleteAuxiliar(id);
            return RedirectToPage("./AuxiliarAdmin");
        }
    }
}
