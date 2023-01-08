﻿// <auto-generated />
using System;
using FastMechanical.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FastMechanical.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FastMechanical.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataFinal")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("MecanicoId")
                        .HasColumnType("int");

                    b.Property<int?>("ServicoId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MecanicoId");

                    b.HasIndex("ServicoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("FastMechanical.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Adicao")
                        .HasColumnType("int");

                    b.Property<int?>("AgendaId")
                        .HasColumnType("int");

                    b.Property<int>("Baixa")
                        .HasColumnType("int");

                    b.Property<string>("ChaveAcessoNotaFiscal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("DataAdicao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataBaixa")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataInsercaoExclusao")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ExecutorId")
                        .HasColumnType("int");

                    b.Property<int>("IdMovimentacao")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroNotaFiscal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("TipoMovimentacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("ExecutorId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("FastMechanical.Models.Materiais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("PorcentagemLucro")
                        .HasColumnType("double");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UnidadeMedidade")
                        .HasColumnType("int");

                    b.Property<double>("ValorCusto")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.ToTable("Materiais");
                });

            modelBuilder.Entity("FastMechanical.Models.PecaAtendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AgendaId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("MaterialId");

                    b.ToTable("PecaAtendimento");
                });

            modelBuilder.Entity("FastMechanical.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(11) CHARACTER SET utf8mb4")
                        .HasMaxLength(11);

                    b.Property<DateTime?>("DataDeNascimento")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(7) CHARACTER SET utf8mb4")
                        .HasMaxLength(7);

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long?>("Telefone")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("FastMechanical.Models.ServicoAtendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AgendaId")
                        .HasColumnType("int");

                    b.Property<int?>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgendaId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicoAtendimento");
                });

            modelBuilder.Entity("FastMechanical.Models.Servicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("FastMechanical.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnoDeFabricacao")
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(25) CHARACTER SET utf8mb4")
                        .HasMaxLength(25);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(7) CHARACTER SET utf8mb4")
                        .HasMaxLength(7);

                    b.Property<string>("Renavam")
                        .IsRequired()
                        .HasColumnType("varchar(11) CHARACTER SET utf8mb4")
                        .HasMaxLength(11);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.HasIndex("Renavam")
                        .IsUnique();

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("FastMechanical.Models.Agenda", b =>
                {
                    b.HasOne("FastMechanical.Models.Pessoa", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("FastMechanical.Models.Pessoa", "Mecanico")
                        .WithMany()
                        .HasForeignKey("MecanicoId");

                    b.HasOne("FastMechanical.Models.Servicos", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId");

                    b.HasOne("FastMechanical.Models.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");
                });

            modelBuilder.Entity("FastMechanical.Models.Estoque", b =>
                {
                    b.HasOne("FastMechanical.Models.Agenda", "Agenda")
                        .WithMany()
                        .HasForeignKey("AgendaId");

                    b.HasOne("FastMechanical.Models.Pessoa", "Executor")
                        .WithMany()
                        .HasForeignKey("ExecutorId");

                    b.HasOne("FastMechanical.Models.Materiais", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId");
                });

            modelBuilder.Entity("FastMechanical.Models.PecaAtendimento", b =>
                {
                    b.HasOne("FastMechanical.Models.Agenda", "Agenda")
                        .WithMany()
                        .HasForeignKey("AgendaId");

                    b.HasOne("FastMechanical.Models.Materiais", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId");
                });

            modelBuilder.Entity("FastMechanical.Models.ServicoAtendimento", b =>
                {
                    b.HasOne("FastMechanical.Models.Agenda", "Agenda")
                        .WithMany()
                        .HasForeignKey("AgendaId");

                    b.HasOne("FastMechanical.Models.Servicos", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId");
                });

            modelBuilder.Entity("FastMechanical.Models.Veiculo", b =>
                {
                    b.HasOne("FastMechanical.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });
#pragma warning restore 612, 618
        }
    }
}
