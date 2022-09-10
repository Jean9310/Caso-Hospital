using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EditarAuxiliarModel : PageModel
    {

        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
        
        [BindProperty]
        public Auxiliar Auxiliar{get; set;}

        public EditarAuxiliarModel(){}
        public ActionResult OnGet(int id)
        {
            this.Auxiliar =_repositorioAuxiliar.GetAuxiliar(id);
            return Page();
        }
         public ActionResult OnPost()
        {
            
            try{


            //Auxiliar.Fecha = System.DateTime.Now;
                Auxiliar auxiliarEditado = _repositorioAuxiliar.UpdateAuxiliar(Auxiliar);
                return RedirectToPage("./AuxiliarAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
