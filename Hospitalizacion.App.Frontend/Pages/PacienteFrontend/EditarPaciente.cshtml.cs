using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class EditarPacienteModel : PageModel
    {
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente{get; set;}
         public ActionResult OnGet(int id)
        {
            this.Paciente  =_repositorioPaciente.GetPaciente(id);
            return Page();
        }
         public ActionResult OnPost()
        {
            
            try{


            
                Paciente  PacienteEditado = _repositorioPaciente .UpdatePaciente (Paciente);
                return RedirectToPage("./PacienteAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
