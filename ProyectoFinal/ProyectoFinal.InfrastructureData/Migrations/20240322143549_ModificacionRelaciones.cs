using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal.InfrastructureData.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionRelaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioSalonEntityId",
                table: "Fichas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fichas_UsuarioSalonEntityId",
                table: "Fichas",
                column: "UsuarioSalonEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fichas_UsuariosSalon_UsuarioSalonEntityId",
                table: "Fichas",
                column: "UsuarioSalonEntityId",
                principalTable: "UsuariosSalon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fichas_UsuariosSalon_UsuarioSalonEntityId",
                table: "Fichas");

            migrationBuilder.DropIndex(
                name: "IX_Fichas_UsuarioSalonEntityId",
                table: "Fichas");

            migrationBuilder.DropColumn(
                name: "UsuarioSalonEntityId",
                table: "Fichas");
        }
    }
}
