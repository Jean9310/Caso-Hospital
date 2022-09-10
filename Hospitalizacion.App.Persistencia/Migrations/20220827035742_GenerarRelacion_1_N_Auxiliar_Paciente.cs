using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospitalizacion.App.Persistencia.Migrations
{
    public partial class GenerarRelacion_1_N_Auxiliar_Paciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetaProfesional",
                table: "SignosVitales");

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "SignosVitales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "PacienteFamiliar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuxiliarId",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnfermeroId",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicoId",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SignosVitalesId",
                table: "HistoriaClinica",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnfermeroId",
                table: "Enfermero",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_PacienteId",
                table: "SignosVitales",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteFamiliar_PacienteId",
                table: "PacienteFamiliar",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_AuxiliarId",
                table: "Paciente",
                column: "AuxiliarId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_EnfermeroId",
                table: "Paciente",
                column: "EnfermeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_MedicoId",
                table: "Paciente",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriaClinica_SignosVitalesId",
                table: "HistoriaClinica",
                column: "SignosVitalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Enfermero_EnfermeroId",
                table: "Enfermero",
                column: "EnfermeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enfermero_Enfermero_EnfermeroId",
                table: "Enfermero",
                column: "EnfermeroId",
                principalTable: "Enfermero",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoriaClinica_SignosVitales_SignosVitalesId",
                table: "HistoriaClinica",
                column: "SignosVitalesId",
                principalTable: "SignosVitales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Auxiliar_AuxiliarId",
                table: "Paciente",
                column: "AuxiliarId",
                principalTable: "Auxiliar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Enfermero_EnfermeroId",
                table: "Paciente",
                column: "EnfermeroId",
                principalTable: "Enfermero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Medico_MedicoId",
                table: "Paciente",
                column: "MedicoId",
                principalTable: "Medico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PacienteFamiliar_Paciente_PacienteId",
                table: "PacienteFamiliar",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SignosVitales_Paciente_PacienteId",
                table: "SignosVitales",
                column: "PacienteId",
                principalTable: "Paciente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfermero_Enfermero_EnfermeroId",
                table: "Enfermero");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoriaClinica_SignosVitales_SignosVitalesId",
                table: "HistoriaClinica");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Auxiliar_AuxiliarId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Enfermero_EnfermeroId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Medico_MedicoId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_PacienteFamiliar_Paciente_PacienteId",
                table: "PacienteFamiliar");

            migrationBuilder.DropForeignKey(
                name: "FK_SignosVitales_Paciente_PacienteId",
                table: "SignosVitales");

            migrationBuilder.DropIndex(
                name: "IX_SignosVitales_PacienteId",
                table: "SignosVitales");

            migrationBuilder.DropIndex(
                name: "IX_PacienteFamiliar_PacienteId",
                table: "PacienteFamiliar");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_AuxiliarId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_EnfermeroId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_MedicoId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_HistoriaClinica_SignosVitalesId",
                table: "HistoriaClinica");

            migrationBuilder.DropIndex(
                name: "IX_Enfermero_EnfermeroId",
                table: "Enfermero");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "PacienteFamiliar");

            migrationBuilder.DropColumn(
                name: "AuxiliarId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "EnfermeroId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "MedicoId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "SignosVitalesId",
                table: "HistoriaClinica");

            migrationBuilder.DropColumn(
                name: "EnfermeroId",
                table: "Enfermero");

            migrationBuilder.AddColumn<string>(
                name: "TargetaProfesional",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
