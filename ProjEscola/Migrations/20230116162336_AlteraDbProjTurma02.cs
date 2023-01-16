using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjEscola.Migrations
{
    /// <inheritdoc />
    public partial class AlteraDbProjTurma02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HorarioTurma",
                table: "ProjTurma",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorarioTurma",
                table: "ProjTurma");
        }
    }
}
