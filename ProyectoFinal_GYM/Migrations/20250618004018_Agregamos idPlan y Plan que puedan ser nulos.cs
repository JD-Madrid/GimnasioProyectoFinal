using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoFinal_GYM.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosidPlanyPlanquepuedansernulos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_planes_planid",
                table: "clientes");

            migrationBuilder.AlterColumn<int>(
                name: "planid",
                table: "clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "idPlan",
                table: "clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_planes_planid",
                table: "clientes",
                column: "planid",
                principalTable: "planes",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_planes_planid",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "idPlan",
                table: "clientes");

            migrationBuilder.AlterColumn<int>(
                name: "planid",
                table: "clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_planes_planid",
                table: "clientes",
                column: "planid",
                principalTable: "planes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
