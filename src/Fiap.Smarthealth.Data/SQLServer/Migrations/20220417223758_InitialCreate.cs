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
                name: "HT01_PSSAUDE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_HT01_PSSAUDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HT02_MEDICO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_HT02_MEDICO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HT03_AGSAUDE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_HT03_AGSAUDE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HT04_FAMILIA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_HT04_FAMILIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HT05_MEMBRO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_HT05_MEMBRO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HT06_REGVACI",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DataAplicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HT06_REGVACI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HT09_ESPECIALI",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HT09_ESPECIALI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HT10_GENERO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Identificacao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HT10_GENERO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HT01_PSSAUDE");

            migrationBuilder.DropTable(
                name: "HT02_MEDICO");

            migrationBuilder.DropTable(
                name: "HT03_AGSAUDE");

            migrationBuilder.DropTable(
                name: "HT04_FAMILIA");

            migrationBuilder.DropTable(
                name: "HT05_MEMBRO");

            migrationBuilder.DropTable(
                name: "HT06_REGVACI");

            migrationBuilder.DropTable(
                name: "HT09_ESPECIALI");

            migrationBuilder.DropTable(
                name: "HT10_GENERO");
        }
    }
}
