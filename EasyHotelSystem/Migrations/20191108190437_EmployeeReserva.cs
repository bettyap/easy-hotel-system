using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHotelSystem.Migrations
{
    public partial class EmployeeReserva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeReserva",
                columns: table => new
                {
                    FuncID = table.Column<int>(nullable: false),
                    ResID = table.Column<int>(nullable: false),
                    RecepcionistaCpfFunc = table.Column<long>(nullable: true),
                    ReservasCodReserva = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeReserva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeReserva_Employee_RecepcionistaCpfFunc",
                        column: x => x.RecepcionistaCpfFunc,
                        principalTable: "Employee",
                        principalColumn: "CpfFunc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeReserva_Reserva_ReservasCodReserva",
                        column: x => x.ReservasCodReserva,
                        principalTable: "Reserva",
                        principalColumn: "CodReserva",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeReserva_RecepcionistaCpfFunc",
                table: "EmployeeReserva",
                column: "RecepcionistaCpfFunc");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeReserva_ReservasCodReserva",
                table: "EmployeeReserva",
                column: "ReservasCodReserva");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeReserva");
        }
    }
}
