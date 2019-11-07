using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHotelSystem.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    CpfFunc = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 40, nullable: false),
                    Bairro = table.Column<string>(maxLength: 30, nullable: false),
                    Complemento = table.Column<string>(maxLength: 10, nullable: true),
                    Cidade = table.Column<string>(maxLength: 30, nullable: false),
                    Cep = table.Column<int>(nullable: false),
                    Telefone = table.Column<long>(nullable: false),
                    DtNasc = table.Column<DateTime>(nullable: false),
                    DtAdmissao = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Cargo = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.CpfFunc);
                });

            migrationBuilder.CreateTable(
                name: "Escorts",
                columns: table => new
                {
                    CpfAcom = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Rg = table.Column<int>(nullable: false),
                    Nascim = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<string>(maxLength: 7, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 40, nullable: false),
                    Bairro = table.Column<string>(maxLength: 30, nullable: false),
                    Complemento = table.Column<string>(maxLength: 10, nullable: true),
                    Cidade = table.Column<string>(maxLength: 30, nullable: false),
                    Cep = table.Column<int>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    Celular = table.Column<long>(nullable: false),
                    Responsavel = table.Column<string>(maxLength: 50, nullable: false),
                    CpfHos = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escorts", x => x.CpfAcom);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    CpfHos = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Rg = table.Column<int>(nullable: false),
                    Nascim = table.Column<DateTime>(nullable: false),
                    Genero = table.Column<string>(maxLength: 7, nullable: false),
                    Profissao = table.Column<string>(maxLength: 20, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 40, nullable: false),
                    Bairro = table.Column<string>(maxLength: 30, nullable: false),
                    Complemento = table.Column<string>(maxLength: 10, nullable: true),
                    Cidade = table.Column<string>(maxLength: 30, nullable: false),
                    Cep = table.Column<int>(nullable: false),
                    Telefone = table.Column<int>(nullable: false),
                    Celular = table.Column<long>(nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: true),
                    CpfAcomp = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.CpfHos);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    CodPagamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumQuarto = table.Column<int>(maxLength: 4, nullable: false),
                    TipoQuarto = table.Column<string>(maxLength: 20, nullable: false),
                    NomeHos = table.Column<string>(maxLength: 50, nullable: false),
                    QtdCriancas = table.Column<int>(nullable: false),
                    QtdAdu = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    DataCheckin = table.Column<DateTime>(nullable: false),
                    DataCheckout = table.Column<DateTime>(nullable: false),
                    HrCheckin = table.Column<DateTime>(nullable: false),
                    HrCheckout = table.Column<DateTime>(nullable: false),
                    CpfFunc = table.Column<long>(nullable: false),
                    CpfHos = table.Column<long>(nullable: false),
                    Taxa = table.Column<decimal>(nullable: false),
                    FormaPag = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.CodPagamento);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    CodReserva = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeHos = table.Column<string>(nullable: true),
                    DataCheckin = table.Column<DateTime>(nullable: false),
                    DataCheckout = table.Column<DateTime>(nullable: false),
                    QtdAcomp = table.Column<int>(nullable: false),
                    CpfFunc = table.Column<long>(nullable: false),
                    CpfHos = table.Column<long>(nullable: false),
                    NumQuarto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.CodReserva);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    NumQuarto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescQuarto = table.Column<string>(maxLength: 20, nullable: false),
                    StatusQuarto = table.Column<string>(maxLength: 15, nullable: false),
                    ValorDiaria = table.Column<decimal>(nullable: false),
                    CodReserva = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.NumQuarto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Escorts");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Room");
        }
    }
}
