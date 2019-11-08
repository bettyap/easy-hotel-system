using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHotelSystem.Migrations
{
    public partial class EmployeePayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeHos",
                table: "Reserva",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeePayment",
                columns: table => new
                {
                    FuncID = table.Column<int>(nullable: false),
                    PagID = table.Column<int>(nullable: false),
                    RecepcionistaCpfFunc = table.Column<long>(nullable: true),
                    PagamentoCodPagamento = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeePayment_Payment_PagamentoCodPagamento",
                        column: x => x.PagamentoCodPagamento,
                        principalTable: "Payment",
                        principalColumn: "CodPagamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeePayment_Employee_RecepcionistaCpfFunc",
                        column: x => x.RecepcionistaCpfFunc,
                        principalTable: "Employee",
                        principalColumn: "CpfFunc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_CpfFunc",
                table: "Reserva",
                column: "CpfFunc");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_NumQuarto",
                table: "Reserva",
                column: "NumQuarto");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CpfHos",
                table: "Payment",
                column: "CpfHos");

            migrationBuilder.CreateIndex(
                name: "IX_Escorts_CpfHos",
                table: "Escorts",
                column: "CpfHos");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePayment_PagamentoCodPagamento",
                table: "EmployeePayment",
                column: "PagamentoCodPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePayment_RecepcionistaCpfFunc",
                table: "EmployeePayment",
                column: "RecepcionistaCpfFunc");

            migrationBuilder.AddForeignKey(
                name: "FK_Escorts_Guest_CpfHos",
                table: "Escorts",
                column: "CpfHos",
                principalTable: "Guest",
                principalColumn: "CpfHos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Guest_CpfHos",
                table: "Payment",
                column: "CpfHos",
                principalTable: "Guest",
                principalColumn: "CpfHos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Employee_CpfFunc",
                table: "Reserva",
                column: "CpfFunc",
                principalTable: "Employee",
                principalColumn: "CpfFunc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Room_NumQuarto",
                table: "Reserva",
                column: "NumQuarto",
                principalTable: "Room",
                principalColumn: "NumQuarto",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Escorts_Guest_CpfHos",
                table: "Escorts");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Guest_CpfHos",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Employee_CpfFunc",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Room_NumQuarto",
                table: "Reserva");

            migrationBuilder.DropTable(
                name: "EmployeePayment");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_CpfFunc",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_NumQuarto",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Payment_CpfHos",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Escorts_CpfHos",
                table: "Escorts");

            migrationBuilder.AlterColumn<string>(
                name: "NomeHos",
                table: "Reserva",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
