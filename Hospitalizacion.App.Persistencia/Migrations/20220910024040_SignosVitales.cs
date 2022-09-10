using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospitalizacion.App.Persistencia.Migrations
{
    public partial class SignosVitales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FrecuenciaCardiaca",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FrecuenciaRespiratoria",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Glicemias",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Oximetria",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PresionArteria",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Temperatura",
                table: "SignosVitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FrecuenciaCardiaca",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "FrecuenciaRespiratoria",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "Glicemias",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "Oximetria",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "PresionArteria",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "Temperatura",
                table: "SignosVitales");
        }
    }
}
