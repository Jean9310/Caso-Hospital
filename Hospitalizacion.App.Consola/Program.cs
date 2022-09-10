// See https://aka.ms/new-console-template for more information
using Hospitalizacion.App.Persistencia;
using Hospitalizacion.App.Dominio;
using System;

public class  Program
{
    private static IRepositorioSignosVitales _repositorioSignosVitales = new RepositorioSignosVitales(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioEnfermero _repositorioEnfermero = new RepositorioEnfermero(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioMedico _repositorioMedico = new RepositorioMedico(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioFamiliar _repositorioFamiliar = new RepositorioFamiliar(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioAuxiliar _repositorioAuxiliar = new RepositorioAuxiliar(new Hospitalizacion.App.Persistencia.AppContext());
    private static IRepositorioPaciente _repositorioPaciente = new RepositorioPaciente(new Hospitalizacion.App.Persistencia.AppContext());
    private static void Main(String[] args)
    {
        Console.WriteLine("BIENVENIDO!");
       
       //AgregarAuxiliar();
       //buscarAuxiliar();
       //eliminarAuxiliar();
       //EditarAuxiliar();
       //VerListaAuxiliar();


       //AgregarPaciente();
       //buscarPaciente();
       //EditarPaciente();
       //eliminarPaciente();

       //AgregarFamiliar();

       AsignarFamiliarPacinte();
       
    }
       public static void AsignarFamiliarPacinte(){

        Paciente paciente = _repositorioPaciente.GetPaciente(1);    
        Console.WriteLine("paciente: "+ paciente.Nombre); 
        paciente.ListaSignosVitales = _repositorioSignosVitales.GetSignosVitalesXPaciente(1).ToList();

        SignosVitales signosVitales = new SignosVitales();
        signosVitales.Registro="xxxxxxxxxxxxxxxxxxxxxhjkjhgfdsdfghjkkjhgfdsdfghjk";
        signosVitales.Oximetria="Oximetria";
        signosVitales.FrecuenciaCardiaca = "frecuencia cardiaca";
        signosVitales.FrecuenciaRespiratoria = " frecuencia";
        signosVitales.Temperatura = "temp";
        signosVitales.Glicemias = "gli";
        signosVitales.PresionArteria = "pre";

        paciente.ListaSignosVitales.Add(signosVitales);   
        _repositorioPaciente.UpdatePaciente(paciente);
     
    }

    

}