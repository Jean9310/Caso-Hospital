﻿// <auto-generated />
using System;
using Hospitalizacion.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospitalizacion.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220827040834_GenerarRelacion_1_N_Paciente_PacienteFamiliar")]
    partial class GenerarRelacion_1_N_Paciente_PacienteFamiliar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Auxiliar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAuxiliar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Auxiliar");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Enfermero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnfermeroId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnfermeroId");

                    b.ToTable("Enfermero");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Familiar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Familiar");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Antecedentes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado_Actual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SignosVitalesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SignosVitalesId");

                    b.ToTable("HistoriaClinica");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetaProfesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AuxiliarId")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnfermeroId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Latitud")
                        .HasColumnType("int");

                    b.Property<int>("Longitud")
                        .HasColumnType("int");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuxiliarId");

                    b.HasIndex("EnfermeroId");

                    b.HasIndex("MedicoId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.PacienteFamiliar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FamiliarId")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FamiliarId");

                    b.HasIndex("PacienteId");

                    b.ToTable("PacienteFamiliar");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.SignosVitales", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Registro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Enfermero", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.Enfermero", null)
                        .WithMany("ListaEnfermero")
                        .HasForeignKey("EnfermeroId");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.HistoriaClinica", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.SignosVitales", "SignosVitales")
                        .WithMany("ListaHistoriaClinica")
                        .HasForeignKey("SignosVitalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SignosVitales");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Paciente", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.Auxiliar", "Auxiliar")
                        .WithMany("ListaPaciente")
                        .HasForeignKey("AuxiliarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospitalizacion.App.Dominio.Enfermero", "Enfermero")
                        .WithMany()
                        .HasForeignKey("EnfermeroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospitalizacion.App.Dominio.Medico", "Medico")
                        .WithMany("Paciente")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auxiliar");

                    b.Navigation("Enfermero");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.PacienteFamiliar", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.Familiar", "Familiar")
                        .WithMany("ListaPacienteFamilia")
                        .HasForeignKey("FamiliarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospitalizacion.App.Dominio.Paciente", "Paciente")
                        .WithMany("ListaPacienteFamilia")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Familiar");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.SignosVitales", b =>
                {
                    b.HasOne("Hospitalizacion.App.Dominio.Paciente", "Paciente")
                        .WithMany("ListaSignosVitales")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Auxiliar", b =>
                {
                    b.Navigation("ListaPaciente");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Enfermero", b =>
                {
                    b.Navigation("ListaEnfermero");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Familiar", b =>
                {
                    b.Navigation("ListaPacienteFamilia");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Medico", b =>
                {
                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.Paciente", b =>
                {
                    b.Navigation("ListaPacienteFamilia");

                    b.Navigation("ListaSignosVitales");
                });

            modelBuilder.Entity("Hospitalizacion.App.Dominio.SignosVitales", b =>
                {
                    b.Navigation("ListaHistoriaClinica");
                });
#pragma warning restore 612, 618
        }
    }
}
