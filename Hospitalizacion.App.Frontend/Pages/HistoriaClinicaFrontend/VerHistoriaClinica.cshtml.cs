using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class VerHistoriaClinicaModel : PageModel
    {
        private static IRepositorioSignosVitales _repositorioSignosVitales = new RepositorioSignosVitales(new Hospitalizacion.App.Persistencia.AppContext());
        public SignosVitales SignosVitales{get; set;}
         private static IRepositorioHistoriaClinica _repositorioHistoriaC = new RepositorioHistoriaClinica(new Hospitalizacion.App.Persistencia.AppContext());
         [BindProperty]
        public IEnumerable<HistoriaClinica> His{get; set;}

        public VerHistoriaClinicaModel(){}
        public ActionResult OnGet(int id)
        {
            
            this.His = _repositorioHistoriaC.GetHistoriaXSigno(id);
            return Page();
        }

        
    }
}
