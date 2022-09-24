using System;

using Hospitalizacion.App.Dominio;

namespace Hospitalizacion.App.Persistencia
{
    public interface IRepositorioPacienteFamiliar
    {
        
        PacienteFamiliar AddPacienteFamiliar(PacienteFamiliar pacienteFamiliar);  

        bool DeletePacienteFamiliar(int idFamiliar, int idPaciente);   // Firma del método

        PacienteFamiliar GetPacienteFamiliar(int idFamiliar, int idPaciente);
      
        IEnumerable<PacienteFamiliar> GetPacienteFamiliarxP(int idFamiliar);

        IEnumerable<PacienteFamiliar> GetAllPacienteF();

        void DeletePacienteF(int id);
    }
    
}







