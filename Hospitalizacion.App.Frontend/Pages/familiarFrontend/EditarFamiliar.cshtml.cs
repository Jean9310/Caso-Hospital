using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EditarFamiliarModel : PageModel
    {
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());

        [BindProperty]
        public Familiar Familiar{get; set;}

        public EditarFamiliarModel(){}
        public ActionResult OnGet(int id)
        {
            this.Familiar =_repositorioFamiliar.GetFamiliar(id);
            return Page();
        }
         public ActionResult OnPost()
        {
            
            try{


            //Auxiliar.Fecha = System.DateTime.Now;
                Familiar familiarEditado = _repositorioFamiliar.UpdateFamiliar(Familiar);
                return RedirectToPage("./FamiliarAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
