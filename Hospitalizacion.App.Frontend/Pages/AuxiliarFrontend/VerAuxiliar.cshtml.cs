using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    


    public class VerAuxiliarModel : PageModel
    {


        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());


        public Auxiliar Auxiliar{get; set;}

        public VerAuxiliarModel(){}
        public ActionResult OnGet(int id)
        {
            this.Auxiliar=_repositorioAuxiliar.GetAuxiliar(id);
            return Page();
        }
    }
}
