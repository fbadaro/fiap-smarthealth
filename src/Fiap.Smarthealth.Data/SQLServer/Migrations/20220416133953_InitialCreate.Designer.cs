﻿// <auto-generated />
using System;
using Fiap.Smarthealth.Data.SQLServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Smarthealth.Data.SQLServer.Migrations
{
    [DbContext(typeof(SmarthealthDBContext))]
    [Migration("20220416133953_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.AgenteSaude", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("AgentesSaude");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.Familia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("Familias");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.FamiliaMembro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NomeSocial")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Responsavel")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Membros");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.Genero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Identificacao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.Medico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.MedicoEspecialidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.PostoSaude", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("PostosSaude");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.RegistroVacina", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataAplicacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("Vencimento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vacinas");
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.AgenteSaude", b =>
                {
                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CNS", "CNS", b1 =>
                        {
                            b1.Property<Guid>("AgenteSaudeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("nvarchar(15)");

                            b1.HasKey("AgenteSaudeId");

                            b1.ToTable("AgentesSaude");

                            b1.WithOwner()
                                .HasForeignKey("AgenteSaudeId");
                        });

                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CPF", "CPF", b1 =>
                        {
                            b1.Property<Guid>("AgenteSaudeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Emissor")
                                .IsRequired()
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(11)
                                .HasColumnType("nvarchar(11)");

                            b1.Property<string>("UF")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.HasKey("AgenteSaudeId");

                            b1.ToTable("AgentesSaude");

                            b1.WithOwner()
                                .HasForeignKey("AgenteSaudeId");
                        });

                    b.Navigation("CNS")
                        .IsRequired();

                    b.Navigation("CPF")
                        .IsRequired();
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.Familia", b =>
                {
                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CNS", "CNS", b1 =>
                        {
                            b1.Property<Guid>("FamiliaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("nvarchar(15)");

                            b1.HasKey("FamiliaId");

                            b1.ToTable("Familias");

                            b1.WithOwner()
                                .HasForeignKey("FamiliaId");
                        });

                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("FamiliaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("nvarchar(150)");

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("nvarchar(9)");

                            b1.Property<string>("Complemento")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("nvarchar(150)");

                            b1.HasKey("FamiliaId");

                            b1.ToTable("Familias");

                            b1.WithOwner()
                                .HasForeignKey("FamiliaId");
                        });

                    b.Navigation("CNS")
                        .IsRequired();

                    b.Navigation("Endereco")
                        .IsRequired();
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.FamiliaMembro", b =>
                {
                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.RG", "RG", b1 =>
                        {
                            b1.Property<Guid>("FamiliaMembroId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("nvarchar(15)");

                            b1.HasKey("FamiliaMembroId");

                            b1.ToTable("Membros");

                            b1.WithOwner()
                                .HasForeignKey("FamiliaMembroId");
                        });

                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CPF", "CPF", b1 =>
                        {
                            b1.Property<Guid>("FamiliaMembroId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Emissor")
                                .IsRequired()
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(11)
                                .HasColumnType("nvarchar(11)");

                            b1.Property<string>("UF")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.HasKey("FamiliaMembroId");

                            b1.ToTable("Membros");

                            b1.WithOwner()
                                .HasForeignKey("FamiliaMembroId");
                        });

                    b.Navigation("CPF")
                        .IsRequired();

                    b.Navigation("RG")
                        .IsRequired();
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.Medico", b =>
                {
                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CRM", "CRM", b1 =>
                        {
                            b1.Property<Guid>("MedicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(10)
                                .HasColumnType("nvarchar(10)");

                            b1.Property<string>("UF")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.HasKey("MedicoId");

                            b1.ToTable("Medicos");

                            b1.WithOwner()
                                .HasForeignKey("MedicoId");
                        });

                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CNPJ", "CNPJ", b1 =>
                        {
                            b1.Property<Guid>("MedicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Emissor")
                                .IsRequired()
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(14)
                                .HasColumnType("nvarchar(14)");

                            b1.HasKey("MedicoId");

                            b1.ToTable("Medicos");

                            b1.WithOwner()
                                .HasForeignKey("MedicoId");
                        });

                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CPF", "CPF", b1 =>
                        {
                            b1.Property<Guid>("MedicoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Emissor")
                                .IsRequired()
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(11)
                                .HasColumnType("nvarchar(11)");

                            b1.Property<string>("UF")
                                .IsRequired()
                                .HasMaxLength(2)
                                .HasColumnType("nvarchar(2)");

                            b1.HasKey("MedicoId");

                            b1.ToTable("Medicos");

                            b1.WithOwner()
                                .HasForeignKey("MedicoId");
                        });

                    b.Navigation("CNPJ")
                        .IsRequired();

                    b.Navigation("CPF")
                        .IsRequired();

                    b.Navigation("CRM")
                        .IsRequired();
                });

            modelBuilder.Entity("Fiap.Smarthealth.Core.Domain.PostoSaude", b =>
                {
                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.Funcionamento", "Funcionamento", b1 =>
                        {
                            b1.Property<Guid>("PostoSaudeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("Abertura")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("Encerramento")
                                .HasColumnType("datetime2");

                            b1.HasKey("PostoSaudeId");

                            b1.ToTable("PostosSaude");

                            b1.WithOwner()
                                .HasForeignKey("PostoSaudeId");
                        });

                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.CNPJ", "CNPJ", b1 =>
                        {
                            b1.Property<Guid>("PostoSaudeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Emissor")
                                .IsRequired()
                                .HasMaxLength(5)
                                .HasColumnType("nvarchar(5)");

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasMaxLength(14)
                                .HasColumnType("nvarchar(14)");

                            b1.HasKey("PostoSaudeId");

                            b1.ToTable("PostosSaude");

                            b1.WithOwner()
                                .HasForeignKey("PostoSaudeId");
                        });

                    b.OwnsOne("Fiap.Smarthealth.Core.Aggregate.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("PostoSaudeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("nvarchar(150)");

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasMaxLength(9)
                                .HasColumnType("nvarchar(9)");

                            b1.Property<string>("Complemento")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("nvarchar(30)");

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasMaxLength(150)
                                .HasColumnType("nvarchar(150)");

                            b1.HasKey("PostoSaudeId");

                            b1.ToTable("PostosSaude");

                            b1.WithOwner()
                                .HasForeignKey("PostoSaudeId");
                        });

                    b.Navigation("CNPJ")
                        .IsRequired();

                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Funcionamento")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
