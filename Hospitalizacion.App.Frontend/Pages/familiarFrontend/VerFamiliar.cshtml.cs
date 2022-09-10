using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class VerFamiliarModel : PageModel
    {
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        public Familiar Familiar{get; set;}

        public VerFamiliarModel(){}
        public ActionResult OnGet(int id)
        {
            this.Familiar=_repositorioFamiliar.GetFamiliar(id);
            return Page();
        }
    }
}
