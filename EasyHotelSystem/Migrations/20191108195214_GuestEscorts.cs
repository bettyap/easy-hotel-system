using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHotelSystem.Migrations
{
    public partial class GuestEscorts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Escorts_Guest_CpfHos",
                table: "Escorts");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Guest_CpfHos",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Room_NumQuarto",
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

            migrationBuilder.CreateTable(
                name: "GuestEscorts",
                columns: table => new
                {
                    HosID = table.Column<int>(nullable: false),
                    PagID = table.Column<int>(nullable: false),
                    HospedeCpfHos = table.Column<long>(nullable: true),
                    AcompanhantesCpfAcom = table.Column<long>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestEscorts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestEscorts_Escorts_AcompanhantesCpfAcom",
                        column: x => x.AcompanhantesCpfAcom,
                        principalTable: "Escorts",
                        principalColumn: "CpfAcom",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GuestEscorts_Guest_HospedeCpfHos",
                        column: x => x.HospedeCpfHos,
                        principalTable: "Guest",
                        principalColumn: "CpfHos",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GuestPayment",
                columns: table => new
                {
                    HosID = table.Column<int>(nullable: false),
                    PagID = table.Column<int>(nullable: false),
                    HospedeCpfHos = table.Column<long>(nullable: true),
                    PagamentoCodPagamento = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuestPayment_Guest_HospedeCpfHos",
                        column: x => x.HospedeCpfHos,
                        principalTable: "Guest",
                        principalColumn: "CpfHos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GuestPayment_Payment_PagamentoCodPagamento",
                        column: x => x.PagamentoCodPagamento,
                        principalTable: "Payment",
                        principalColumn: "CodPagamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuestEscorts_AcompanhantesCpfAcom",
                table: "GuestEscorts",
                column: "AcompanhantesCpfAcom");

            migrationBuilder.CreateIndex(
                name: "IX_GuestEscorts_HospedeCpfHos",
                table: "GuestEscorts",
                column: "HospedeCpfHos");

            migrationBuilder.CreateIndex(
                name: "IX_GuestPayment_HospedeCpfHos",
                table: "GuestPayment",
                column: "HospedeCpfHos");

            migrationBuilder.CreateIndex(
                name: "IX_GuestPayment_PagamentoCodPagamento",
                table: "GuestPayment",
                column: "PagamentoCodPagamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestEscorts");

            migrationBuilder.DropTable(
                name: "GuestPayment");

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
                name: "FK_Reserva_Room_NumQuarto",
                table: "Reserva",
                column: "NumQuarto",
                principalTable: "Room",
                principalColumn: "NumQuarto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
