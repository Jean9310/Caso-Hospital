using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class VerEnfermeroModel : PageModel
    {

        


        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        

        public IEnumerable<Paciente> Pac{get; set;}
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
        public Enfermero Enfermero{get; set;}

        public VerEnfermeroModel(){}
        public ActionResult OnGet(int id)
        {
            
            this.Pac=_repositorioPaciente.GetEnfermeroParaPaciente(id);
            this.Enfermero=_repositorioEnfermero.GetEnfermero(id);
            return Page();
        }
    }
}
