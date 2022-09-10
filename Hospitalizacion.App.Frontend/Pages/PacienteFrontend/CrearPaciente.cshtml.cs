using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;
using System;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearPacienteModel : PageModel
    {
         private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
         [BindProperty]
        public Paciente Paciente{get; set;}

        public CrearPacienteModel(){

             }
        public ActionResult OnGet()
        {
            return Page();
        }

        public ActionResult OnPost()
        {
            
            try{


                Paciente PacienteAdicionado = _repositorioPaciente.AddPaciente(Paciente);
                return RedirectToPage("./PacienteAdmin");
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
