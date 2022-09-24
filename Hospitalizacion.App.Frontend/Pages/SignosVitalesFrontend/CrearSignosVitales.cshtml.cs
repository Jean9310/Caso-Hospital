using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearSignosVitalesModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente{get; set;}
        
        
        private static IRepositorioSignosVitales _repositorioSignosVitales = new RepositorioSignosVitales(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        
        public SignosVitales SignosVitales{get; set;}

        public CrearSignosVitalesModel(){}




        public ActionResult OnGet(int id)
        {
            this.Paciente= _repositorioPaciente.GetPaciente(id);
            this.SignosVitales=_repositorioSignosVitales.GetSignosVitales(id);
            
           // SignosVitales.PacienteId = 2042;
           
             return Page();
           
            
        }

          public ActionResult OnPost()
        {
            
            try{


            //Auxiliar.Fecha = System.DateTime.Now;
               SignosVitales Signos = _repositorioSignosVitales.AddSignosVitales(SignosVitales);
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
