using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class FamiliarAdminModel : PageModel
    {
         private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        public IEnumerable<Familiar> Fam{get; set;}

        public FamiliarAdminModel()
        {

        }

        public void OnGet()
        {
          this.Fam =_repositorioFamiliar.GetAllFamiliar();
        }
    }
}
