using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Smarthealth.Data.SQLServer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentesSaude",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CPF_Numero = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CPF_Emissor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CPF_UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CNS_Numero = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentesSaude", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidade = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Familias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sobrenome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CNS_Numero = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Endereco_Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco_Complemento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Endereco_Bairro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco_CEP = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CPF_Numero = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CPF_Emissor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CPF_UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CNPJ_Numero = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    CNPJ_Emissor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CRM_Numero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CRM_UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Membros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NomeSocial = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CPF_Numero = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CPF_Emissor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CPF_UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    RG_Numero = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Responsavel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostosSaude",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CNPJ_Numero = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    CNPJ_Emissor = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Endereco_Logradouro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco_Complemento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Endereco_Bairro = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Endereco_CEP = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Funcionamento_Abertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Funcionamento_Encerramento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostosSaude", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DataAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacinas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentesSaude");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Familias");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Membros");

            migrationBuilder.DropTable(
                name: "PostosSaude");

            migrationBuilder.DropTable(
                name: "Vacinas");
        }
    }
}
