using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospitalizacion.App.Persistencia.Migrations
{
    public partial class Ulti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "SignosVitales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "HistoriaClinica",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "SignosVitales");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "HistoriaClinica");
        }
    }
}
