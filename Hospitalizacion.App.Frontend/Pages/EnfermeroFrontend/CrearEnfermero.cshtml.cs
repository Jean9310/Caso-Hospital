using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearEnfermeroModel : PageModel
    {
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());

         [BindProperty]
        public Enfermero Enfermero{get; set;}

        public CrearEnfermeroModel(){}
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            
            try{


           
                Enfermero EnfermeroAdicionado = _repositorioEnfermero.AddEnfermero(Enfermero);
                return RedirectToPage("./EnfermeroAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
       
    }
}
