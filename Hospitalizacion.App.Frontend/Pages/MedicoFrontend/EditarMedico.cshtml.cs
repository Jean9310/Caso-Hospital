using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EditarMedicoModel : PageModel
    {
         private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Medico  Medico {get; set;}

        public EditarMedicoModel(){}
        public ActionResult OnGet(int id)
        {
            this.Medico  =_repositorioMedico.GetMedico(id);
            return Page();
        }
         public ActionResult OnPost()
        {
            
            try{


            
                Medico  MedicoEditado = _repositorioMedico .UpdateMedico (Medico );
                return RedirectToPage("./MedicoAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
