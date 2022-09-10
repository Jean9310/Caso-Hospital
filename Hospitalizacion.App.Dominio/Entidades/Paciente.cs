using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hospitalizacion.App.Dominio
{
    public class Paciente: Persona
    {
        public int Id {get; set; }
        
        [Required(ErrorMessage="este campo Direccion es obligatorio")]
        public string Direccion {get; set; }
        
        [Required(ErrorMessage="este campo Ciudad es obligatorio")]
        public string Ciudad {get; set; }

        [Required(ErrorMessage="este campo Fecha de Nacimiento es obligatorio")]
        public DateTime FechaNacimiento {get; set; }

        [Required(ErrorMessage="este campo Latitud es obligatorio")]
        public string Latitud {get; set; }

        [Required(ErrorMessage="este campo Longitudes obligatorio")]
        public string Longitud {get; set; }

        
        
        public List<PacienteFamiliar> ListaPacienteFamilia {get; set;}
        public int AuxiliarId {get; set; }
        public Auxiliar Auxiliar {get; set; }
        public int EnfermeroId {get; set; }
        public Enfermero Enfermero {get; set; }
        public int MedicoId {get; set; }
        public Medico Medico {get; set; }

        public List<SignosVitales> ListaSignosVitales {get; set; }


    }
}