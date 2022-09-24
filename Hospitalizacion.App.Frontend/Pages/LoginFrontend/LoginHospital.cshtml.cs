using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class LoginHospitalModel : PageModel
    {
        private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Familiar Familiar{get; set;}

        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Auxiliar Auxiliar{get; set;}

        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente{get; set;}

        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Enfermero Enfermero{get; set;}

        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Medico Medico{get; set;}

        [BindProperty]
        public string UserName {get; set;}
        [BindProperty]
        public string Password {get; set;}
        [BindProperty]
        public string TipoPersona{get; set;}
        public void OnGet()
        {
            
        }

        public ActionResult OnPost(string UserName, string Password)
        {
           
            //TempData["UserName"]= this.UserName;
            

            if(TipoPersona=="a"){Console.WriteLine("Hola Medico:" + this.UserName);
                this.Medico = _repositorioMedico.GetNombreDocumento(UserName, Password);
                if(Medico.Nombre==UserName && Medico.Telefono==Password)
                {
                      
                   // this.Medico=_repositorioMedico.GetMedico(Medico.Id);
                   return  RedirectToPage ("../MedicoFrontend/VerMedicoModel", "Medico.Id");
                  
                   
                //Console.WriteLine("Esttoy aqui" + this.UserName);
                }
                
               
            }
            if(TipoPersona=="b"){Console.WriteLine("Hola Enfermero: "+ this.UserName);
                this.Enfermero =_repositorioEnfermero.GetNombreDocumentoEnfermero(UserName, Password);
                if(Enfermero.Nombre==UserName && Enfermero.Telefono==Password)
                {
                    return  RedirectToPage("../EnfermeroFrontend/EnfermeroAdmin");
                }
              
            }
            if(TipoPersona=="c"){Console.WriteLine("Hola Paciente: "+ this.UserName);
               this.Paciente = _repositorioPaciente.GetNombreDocumentoPaciente(UserName, Password);
               if(Paciente.Nombre==UserName && Paciente.Telefono==Password)
               {
                    return  RedirectToPage("../PacienteFrontend/PacienteAdmin");
               }
               
            }
            if(TipoPersona=="d"){Console.WriteLine("Hola Auxiliar: "+ this.UserName);
                this.Auxiliar = _repositorioAuxiliar.GetNombreDocumentoAuxiliar(UserName, Password);
                if(Auxiliar.Nombre==UserName && Auxiliar.Telefono==Password)
                {
                    return  RedirectToPage("../AuxiliarFrontend/AuxiliarAdmin");
                }
                        
            }
            if(TipoPersona=="e"){Console.WriteLine("Hola Familiar: "+ this.UserName);
                this.Familiar = _repositorioFamiliar.GetNombreDocumentoFamiliar(UserName, Password);
                if(Familiar.Nombre==UserName && Familiar.Telefono==Password)
                {
                    return  RedirectToPage("../FamiliarFrontend/FamiliarAdmin");
                }
                     
            }
            return  Page();
        }
    }
}
