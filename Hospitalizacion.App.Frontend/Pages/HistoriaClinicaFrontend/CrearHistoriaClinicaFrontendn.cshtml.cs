using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearHistoriaClinicaFrontendnModel : PageModel
    {
        private static IRepositorioSignosVitales _repositorioSignosVitales = new RepositorioSignosVitales(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        
        public SignosVitales SignosVitales{get; set;}


        private static IRepositorioHistoriaClinica _repositorioHistoriaC = new RepositorioHistoriaClinica(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        
        public HistoriaClinica HistoriaClinica{get; set;}

        public CrearHistoriaClinicaFrontendnModel(){}


        public ActionResult OnGet(int id)
        {
            this.SignosVitales=_repositorioSignosVitales.GetSignosVitales(id);
            
            return Page();
        }

        public ActionResult OnPost()
        {
            
            try{


            //Auxiliar.Fecha = System.DateTime.Now;
               HistoriaClinica historia = _repositorioHistoriaC.AddHistoriaClinica(HistoriaClinica);
                //  return RedirectToPage("./PacienteAdmin");
                //  ("./SignosVitalesAdmin");
                return Page();
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
