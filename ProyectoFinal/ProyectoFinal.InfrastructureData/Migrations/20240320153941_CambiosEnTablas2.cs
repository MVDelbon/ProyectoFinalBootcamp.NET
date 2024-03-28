using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.InfrastructureData.Migrations
{
    /// <inheritdoc />
    public partial class CambiosEnTablas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fichas",
                newName: "FichaClienteEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FichaClienteEntityId",
                table: "Fichas",
                newName: "Id");
        }
    }
}
