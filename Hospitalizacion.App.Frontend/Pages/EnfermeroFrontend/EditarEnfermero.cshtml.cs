using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;


namespace Hospitalizacion.App.Frontend.Pages
{
    public class EditarEnfermeroModel : PageModel
    {
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
         
       [BindProperty]
        public Enfermero Enfermero{get; set;}

        public EditarEnfermeroModel(){}
        public ActionResult OnGet(int id)
        {
            this.Enfermero =_repositorioEnfermero.GetEnfermero(id);
            return Page();
        }
         public ActionResult OnPost()
        {
            
            try{


            
                Enfermero EnfermeroEditado = _repositorioEnfermero.UpdateEnfermero(Enfermero);
                return RedirectToPage("./EnfermeroAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
