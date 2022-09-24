using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hospitalizacion.App.Dominio;
using Hospitalizacion.App.Persistencia;

namespace Hospitalizacion.App.Frontend.Pages
{
    public class VerPacientePersonalModel : PageModel
    {

        
         private static IRepositorioSignosVitales _repositorioSignosVitales = new RepositorioSignosVitales(new Hospitalizacion.App.Persistencia.AppContext());
        public SignosVitales SignosVitales{get; set;}
        private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
        public Medico Medico{get; set;}
        private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
        public Enfermero Enfermero{get; set;}
        private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
        public Auxiliar Auxiliar{get; set;}

        public  IEnumerable<SignosVitales> sig{get; set;}

        private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
        public Paciente Paciente{get; set;}

        public VerPacientePersonalModel(){}
        public ActionResult OnGet(int id)
        {
            this.Paciente=_repositorioPaciente.GetPaciente(id);
            this.Medico= _repositorioMedico.GetMedicoXP(Paciente.MedicoId);
            this.Enfermero= _repositorioEnfermero.GetEnfermeroXP(Paciente.EnfermeroId);
            this.Auxiliar= _repositorioAuxiliar.GetAuxiliarXP(Paciente.AuxiliarId);
            this.sig= _repositorioSignosVitales.GetSignosVitalesXPaciente(Paciente.Id);
            
            return Page();
        }

    }
}
