// See https://aka.ms/new-console-template for more information
using Hospitalizacion.App.Persistencia;
using Hospitalizacion.App.Dominio;
using System;

public class  Program
{
    private static IRepositorioPacienteFamiliar _repositorioPF = new RepositorioPacienteFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioHistoriaClinica _repositorioHistoriaC = new RepositorioHistoriaClinica(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioSignosVitales _repositorioSignosVitales = new RepositorioSignosVitales(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
    private static void Main(String[] args)
    {
        Console.WriteLine("BIENVENIDO!2");
       
       //AgregarAuxiliar();
       //buscarAuxiliar();
       //eliminarAuxiliar();
       //EditarAuxiliar();
       //VerListaAuxiliar();
        AgregarPF();
        //AgregarHistoria();
       //AgregarPaciente();
       //buscarPaciente();
       //EditarPaciente();
       //eliminarPaciente();

       //AgregarFamiliar();

       //AsignarFamiliarPacinte();
       
    }


     static void AgregarPF()
    {
        Console.WriteLine("agregando Paciente...");
        PacienteFamiliar paciente = new PacienteFamiliar();

        
        paciente.PacienteId = 2042;
        paciente.FamiliarId = 3;

        _repositorioPF.AddPacienteFamiliar(paciente);
        Console.WriteLine("se a adiciono el Paciente");
    }


/*
     static void  AgregarHistoria()
    {
        Console.WriteLine("agregando Historia...");
        HistoriaClinica paciente = new HistoriaClinica();

        paciente.Antecedentes = "calle 18h 20 50";
        paciente.Estado_Actual = "soacha";
        paciente.Fecha = DateTime.Now;
        paciente.SignosVitalesId = 51;
        

        _repositorioHistoriaC.AddHistoriaClinica(paciente);
        Console.WriteLine("se a adiciono el Paciente");
    }

*/
   /*

    static void AgregarPaciente()
    {
        Console.WriteLine("agregando Paciente...");
        Paciente paciente = new Paciente();

        paciente.Direccion = "calle 18h 20 50";
        paciente.Ciudad = "soacha";
        paciente.FechaNacimiento = DateTime.Now;
        paciente.Latitud = 12;
        paciente.Longitud = 34;
        paciente.Nombre = "oscar";
        paciente.Apellido = "naranjo";
        paciente.Telefono = "34875444";
        paciente.Genero = "hombre";
        paciente.AuxiliarId =5;
        paciente.EnfermeroId = 3;
        paciente.MedicoId = 1;

        _repositorioPaciente.AddPaciente(paciente);
        Console.WriteLine("se a adiciono el Paciente");
    }

*/
/*
      static void buscarPaciente()
    {
        Console.WriteLine("buscando Paciente...");
        var paciente = _repositorioPaciente.GetPaciente(4);
        Console.WriteLine("Dirrecion: "+ paciente.Direccion);
        Console.WriteLine("Ciudad: "+ paciente.Ciudad);
        Console.WriteLine("Fecha: "+ paciente.FechaNacimiento);
        Console.WriteLine("Latitud: "+ paciente.Latitud);
        Console.WriteLine("Longitud: "+ paciente.Longitud);
        Console.WriteLine("Nombre: "+ paciente.Nombre);
        Console.WriteLine("Apellido: "+paciente.Apellido);
        Console.WriteLine("Telefono: "+paciente.Telefono);
        Console.WriteLine("Genero: "+paciente.Genero);
        Console.WriteLine("Auxiliar: "+ paciente.AuxiliarId);
        Console.WriteLine("Enfermero: "+ paciente.EnfermeroId);
        Console.WriteLine("Medico: "+ paciente.MedicoId);
        
    }
*/
/*
    static void EditarPaciente()
    {
        Console.WriteLine("editando el Paciente");
        
        var paciente = _repositorioPaciente.GetPaciente(4);
        
        paciente.Direccion = "calle 18h 20 50";
        paciente.Ciudad = "soacha";
        paciente.FechaNacimiento = DateTime.Now;
        paciente.Latitud = 12;
        paciente.Longitud = 34;
        paciente.Nombre = "oscar";
        paciente.Apellido = "naranjo";
        paciente.Telefono = "34875444";
        paciente.Genero = "hombre";
        paciente.AuxiliarId =5;
        paciente.EnfermeroId = 3;
        paciente.MedicoId = 1;
        

        _repositorioPaciente.UpdatePaciente(paciente);
        Console.WriteLine("se a editando  el Paciente");
    }
*/
/*
    static void eliminarPaciente()
    {
        Console.WriteLine("Eliminando Paciente...");
        _repositorioPaciente.DeletePaciente(4);
        Console.WriteLine("Paciente Eliminado");
        
        
    }
*/
/*
       public static void AsignarFamiliarPacinte(){

        Paciente paciente = _repositorioPaciente.GetPaciente(66);    
        Console.WriteLine("paciente: "+ paciente.Nombre); 
        paciente.ListaSignosVitales = _repositorioSignosVitales.GetSignosVitalesXPaciente(66).ToList();

        SignosVitales signosVitales = new SignosVitales();
        signosVitales.Fecha=DateTime.Now;
        signosVitales.Registro="adad";
        signosVitales.Oximetria="Frecuencia";
        signosVitales.FrecuenciaCardiaca = " cardiaca";
        signosVitales.FrecuenciaRespiratoria = " frecuencia t";
        signosVitales.Temperatura = "tempada";
        signosVitales.Glicemias = "glicccc";
        signosVitales.PresionArteria = "preadad";

        paciente.ListaSignosVitales.Add(signosVitales);   
        _repositorioPaciente.UpdatePaciente(paciente);
     
    }
*/
    

}