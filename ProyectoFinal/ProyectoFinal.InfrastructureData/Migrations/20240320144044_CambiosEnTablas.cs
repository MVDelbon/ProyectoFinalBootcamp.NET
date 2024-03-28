using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.InfrastructureData.Migrations
{
    /// <inheritdoc />
    public partial class CambiosEnTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Fichas_FichaId",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "FichaClienteId",
                table: "Registros");

            migrationBuilder.RenameColumn(
                name: "FichaId",
                table: "Registros",
                newName: "FichaClienteEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Registros_FichaId",
                table: "Registros",
                newName: "IX_Registros_FichaClienteEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Fichas_FichaClienteEntityId",
                table: "Registros",
                column: "FichaClienteEntityId",
                principalTable: "Fichas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Fichas_FichaClienteEntityId",
                table: "Registros");

            migrationBuilder.RenameColumn(
                name: "FichaClienteEntityId",
                table: "Registros",
                newName: "FichaId");

            migrationBuilder.RenameIndex(
                name: "IX_Registros_FichaClienteEntityId",
                table: "Registros",
                newName: "IX_Registros_FichaId");

            migrationBuilder.AddColumn<int>(
                name: "FichaClienteId",
                table: "Registros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Fichas_FichaId",
                table: "Registros",
                column: "FichaId",
                principalTable: "Fichas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
