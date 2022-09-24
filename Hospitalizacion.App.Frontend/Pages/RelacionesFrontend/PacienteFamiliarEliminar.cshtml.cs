using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class PacienteFamiliarEliminarModel : PageModel
    {
        private static IRepositorioPacienteFamiliar _repositorioPF = new RepositorioPacienteFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public PacienteFamiliar PacienteFamiliar{get; set;}

        public IEnumerable<PacienteFamiliar> pf{get; set;}

        public PacienteFamiliarEliminarModel(){}
   
        public ActionResult OnGet(int id)
        {
           this.pf = _repositorioPF.GetAllPacienteF();
            _repositorioPF.DeletePacienteF(id);
            //return RedirectToPage("./AuxiliarAdmin");
            return Page();
            
        }
    }
}
