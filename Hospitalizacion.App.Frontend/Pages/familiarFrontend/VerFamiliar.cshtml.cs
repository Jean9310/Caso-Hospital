using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class VerFamiliarModel : PageModel
    {
        private static IRepositorioPacienteFamiliar _repositorioPF = new RepositorioPacienteFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        public IEnumerable<PacienteFamiliar> pf{get; set;}

        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        public Familiar Familiar{get; set;}

        public VerFamiliarModel(){}
        public ActionResult OnGet(int id)
        {
            this.pf = _repositorioPF.GetPacienteFamiliarxP(id);
            this.Familiar=_repositorioFamiliar.GetFamiliar(id);
            return Page();
        }
    }
}
