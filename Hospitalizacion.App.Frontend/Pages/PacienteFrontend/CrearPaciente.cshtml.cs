using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;
using System;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class CrearPacienteModel : PageModel
    {   


        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
         public Medico  Medico {get; set;}
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Enfermero Enfermero{get; set;}
        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Auxiliar Auxiliar{get; set;}
        
        
        
        
        
        
        
        
        public IEnumerable<Medico> Medicos{get; set;}
        
        public IEnumerable<Enfermero> Enfermeros{get; set;}

        public IEnumerable<Auxiliar> Auxiliares{get; set;}
        
        
        
        
        
        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        [BindProperty]
        public Paciente Paciente{get; set;}

        public CrearPacienteModel(){

             }
        public ActionResult OnGet()
        {
            this.Medicos = _repositorioMedico.GetAllMedico();
            this.Enfermeros = _repositorioEnfermero.GetAllEnfermero();
            this.Auxiliares = _repositorioAuxiliar.GetAllAuxiliar();
            return Page();
        }

        public ActionResult OnPost()
        {
            
            try{
                this.Paciente.MedicoId = Medico.Id;
                this.Paciente.EnfermeroId = Enfermero.Id;
                this.Paciente.AuxiliarId = Auxiliar.Id;


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
