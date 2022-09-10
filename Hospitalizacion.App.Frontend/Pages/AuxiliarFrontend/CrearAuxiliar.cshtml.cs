using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearAuxiliarModel : PageModel
    {
        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
        
        [BindProperty]
        public Auxiliar Auxiliar{get; set;}

        public CrearAuxiliarModel(){}
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            
            try{


            //Auxiliar.Fecha = System.DateTime.Now;
                Auxiliar auxiliarAdicionado = _repositorioAuxiliar.AddAuxiliar(Auxiliar);
                return RedirectToPage("./AuxiliarAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
