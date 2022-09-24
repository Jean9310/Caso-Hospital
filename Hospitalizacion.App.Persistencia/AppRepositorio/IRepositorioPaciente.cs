using System;

using Hospitalizacion.App.Dominio;


namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        Paciente AddPaciente(Paciente paciente);  

        void DeletePaciente(int id);   // Firma del método

        Paciente GetPaciente(int id);

        IEnumerable<Paciente> GetAllPaciente();

        Paciente UpdatePaciente(Paciente paciente);



        IEnumerable<Paciente> GetMedicoParaPaciente(int idMedico);
        IEnumerable<Paciente> GetEnfermeroParaPaciente(int idEnfermero);
        IEnumerable<Paciente> GetAuxiliarParaPaciente(int idAuxiliar);


        Paciente GetNombreDocumentoPaciente(string dato1, string dato2);

        
    }
}