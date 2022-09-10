using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class ElminarFamiliarModel : PageModel
    {
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
       

        public Familiar Familiar{get; set;}
        public ActionResult OnGet(int id)
        {
            
            _repositorioFamiliar.DeleteFamiliar(id);
            return RedirectToPage("./FamiliarAdmin");
            
        }
        
    }
}
