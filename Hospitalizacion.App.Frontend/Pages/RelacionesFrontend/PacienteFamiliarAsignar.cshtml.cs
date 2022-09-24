using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class PacienteFamiliarAsignarModel : PageModel
    {


        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente{get; set;}
        
        
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Familiar Familiar{get; set;}
        
        public IEnumerable<Paciente> Paci{get; set;}
        public IEnumerable<Familiar> Fam{get; set;}



        private static IRepositorioPacienteFamiliar _repositorioPF = new RepositorioPacienteFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public PacienteFamiliar PacienteFamiliar{get; set;}

       
       
       
        public PacienteFamiliarAsignarModel(){}
       
        public ActionResult OnGet()
        {
            this.Paci =_repositorioPaciente.GetAllPaciente();
            this.Fam =_repositorioFamiliar.GetAllFamiliar();
            return Page();
        }
          
          
          
        public ActionResult OnPost()
        {
            
            try{

                // Console.WriteLine("Hola Medico:" + this.Paciente.Id);
                //  Console.WriteLine("Hola Medico:" + this.Familiar.Id);
                // this.PacienteFamiliar.FamiliarId = Familiar.Id;
                // this.PacienteFamiliar.PacienteId = Paciente.Id;
                


            //Auxiliar.Fecha = System.DateTime.Now;
                PacienteFamiliar pf= _repositorioPF.AddPacienteFamiliar(PacienteFamiliar);
                return RedirectToPage("../AuxiliarFrontend/AuxiliarAdmin");
                
                
            }catch(System.Exception e)
            {
                ViewData["Error"] = "Error"+ e.Message;
                return Page();
            }
            
        }
    }
}
 