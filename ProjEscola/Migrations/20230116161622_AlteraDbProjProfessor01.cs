using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjEscola.Migrations
{
    /// <inheritdoc />
    public partial class AlteraDbProjProfessor01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertificadosProfessor",
                table: "ProjProfessor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisponibilidadeHorarioProfessor",
                table: "ProjProfessor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailProfessor",
                table: "ProjProfessor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorHoraProfessor",
                table: "ProjProfessor",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CertificadosProfessor",
                table: "ProjProfessor");

            migrationBuilder.DropColumn(
                name: "DisponibilidadeHorarioProfessor",
                table: "ProjProfessor");

            migrationBuilder.DropColumn(
                name: "EmailProfessor",
                table: "ProjProfessor");

            migrationBuilder.DropColumn(
                name: "ValorHoraProfessor",
                table: "ProjProfessor");
        }
    }
}
