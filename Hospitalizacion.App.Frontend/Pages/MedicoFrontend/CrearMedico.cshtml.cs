using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearMedicoModel : PageModel
    {
         private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());

        [BindProperty]
        public Medico Medico{get; set;}

        public CrearMedicoModel(){}
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            
            try{


            
                Medico MedicoAdicionado = _repositorioMedico.AddMedico(Medico);
                return RedirectToPage("./MedicoAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
