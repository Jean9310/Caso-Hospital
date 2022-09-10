using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearFamiliarModel : PageModel
    {
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
       
       
        [BindProperty]
        public Familiar Familiar{get; set;}

        public CrearFamiliarModel(){}
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            
            try{


            //Auxiliar.Fecha = System.DateTime.Now;
                Familiar familiarAdicionado = _repositorioFamiliar.AddFamiliar(Familiar);
                return RedirectToPage("./FamiliarAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
