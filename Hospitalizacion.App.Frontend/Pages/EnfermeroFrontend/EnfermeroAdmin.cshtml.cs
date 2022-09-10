using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EnfermeroAdminModel : PageModel
    {
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
        public IEnumerable<Enfermero> Enf{get; set;}

        public EnfermeroAdminModel()
        {

        }

        public void OnGet()
        {
          this.Enf =_repositorioEnfermero.GetAllEnfermero();
        }
    }
}
