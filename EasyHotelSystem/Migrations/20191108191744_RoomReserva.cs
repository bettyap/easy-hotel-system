using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHotelSystem.Migrations
{
    public partial class RoomReserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Employee_CpfFunc",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_CpfFunc",
                table: "Reserva");

            migrationBuilder.CreateTable(
                name: "RoomReserva",
                columns: table => new
                {
                    QuarID = table.Column<int>(nullable: false),
                    ResID = table.Column<int>(nullable: false),
                    QuartoNumQuarto = table.Column<int>(nullable: true),
                    ReservasCodReserva = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomReserva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomReserva_Room_QuartoNumQuarto",
                        column: x => x.QuartoNumQuarto,
                        principalTable: "Room",
                        principalColumn: "NumQuarto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomReserva_Reserva_ReservasCodReserva",
                        column: x => x.ReservasCodReserva,
                        principalTable: "Reserva",
                        principalColumn: "CodReserva",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomReserva_QuartoNumQuarto",
                table: "RoomReserva",
                column: "QuartoNumQuarto");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReserva_ReservasCodReserva",
                table: "RoomReserva",
                column: "ReservasCodReserva");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomReserva");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_CpfFunc",
                table: "Reserva",
                column: "CpfFunc");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Employee_CpfFunc",
                table: "Reserva",
                column: "CpfFunc",
                principalTable: "Employee",
                principalColumn: "CpfFunc",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
