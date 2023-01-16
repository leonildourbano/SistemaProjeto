using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjEscola.Migrations
{
    /// <inheritdoc />
    public partial class AlteraDbProjEstudante01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataNascimentoEstudante",
                table: "ProjEstudante",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmailEstudante",
                table: "ProjEstudante",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FoneEstudante",
                table: "ProjEstudante",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimentoEstudante",
                table: "ProjEstudante");

            migrationBuilder.DropColumn(
                name: "EmailEstudante",
                table: "ProjEstudante");

            migrationBuilder.DropColumn(
                name: "FoneEstudante",
                table: "ProjEstudante");
        }
    }
}
