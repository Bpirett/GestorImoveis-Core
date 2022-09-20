﻿// <auto-generated />
using System;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20220130173103_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Entities.Anuncio", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnName("ANC_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Area")
                        .HasColumnName("ANC_AREA")
                        .HasColumnType("int");

                    b.Property<string>("Ativo")
                        .HasColumnName("ANC_ATIVO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bairro")
                        .HasColumnName("ANC_BAIRRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Brinquedoteca")
                        .HasColumnName("ANC_BRINQUE")
                        .HasColumnType("bit");

                    b.Property<bool>("Churrasqueira")
                        .HasColumnName("ANC_CHURRASQUEIRA")
                        .HasColumnType("bit");

                    b.Property<string>("Cidade")
                        .HasColumnName("ANC_CIDADE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnName("ANC_DTATUALI")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("ANC_DTCAD")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dormitorio")
                        .HasColumnName("ANC_QTDORMI")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnName("ANC_END")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Festas")
                        .HasColumnName("ANC_SFESTA")
                        .HasColumnType("bit");

                    b.Property<bool>("Ginastica")
                        .HasColumnName("ANC_GISNASTICA")
                        .HasColumnType("bit");

                    b.Property<bool>("Jogos")
                        .HasColumnName("ANC_SJOGOS")
                        .HasColumnType("bit");

                    b.Property<string>("Negocio")
                        .HasColumnName("ANC_TPNEG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obs")
                        .HasColumnName("ANC_DESCRICAO")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(200000);

                    b.Property<bool>("Permuta")
                        .HasColumnName("ANC_PERMUTA")
                        .HasColumnType("bit");

                    b.Property<bool>("Piscina")
                        .HasColumnName("ANC_PISCINA")
                        .HasColumnType("bit");

                    b.Property<bool>("Playgroud")
                        .HasColumnName("ANC_PLAYGROUD")
                        .HasColumnType("bit");

                    b.Property<bool>("Poliesportiva")
                        .HasColumnName("ANC_POLIESP")
                        .HasColumnType("bit");

                    b.Property<int>("Suites")
                        .HasColumnName("ANC_QTSUITES")
                        .HasColumnType("int");

                    b.Property<string>("TipoImovel")
                        .HasColumnName("ANC_TPIMOVEL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Vagas")
                        .HasColumnName("ANC_QTVAGAS")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnName("ANC_VALOR")
                        .HasColumnType("float");

                    b.Property<double>("VlrIptu")
                        .HasColumnName("ANC_VLRIPTU")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("UserId");

                    b.ToTable("TB_ANUNCIO");
                });

            modelBuilder.Entity("Entities.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Bairro")
                        .HasColumnName("USR_BAIRRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnName("USR_CPF")
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.Property<string>("Celular")
                        .HasColumnName("USR_CELULAR")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Cep")
                        .HasColumnName("USR_CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnName("USR_CIDADE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnName("USR_COMPL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento2")
                        .HasColumnName("USR_COMPL2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Endereco")
                        .HasColumnName("USR_ENDERECO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idade")
                        .HasColumnName("USR_IDADE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .HasColumnName("USR_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("NumeroImovel")
                        .HasColumnName("USR_NUMIMOV")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnName("USR_TELEFONE")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("TipoUsuario")
                        .HasColumnName("USR_TPUSU")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Uf")
                        .HasColumnName("USR_UF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Entities.Entities.Boleto", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnName("BOL_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnName("BOL_DTPAG")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnName("BOL_DTVENC")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnName("BOL_ENDERECO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdContrato")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("JrMulta")
                        .HasColumnName("BOL_JRMULTA")
                        .HasColumnType("float");

                    b.Property<string>("Locador")
                        .HasColumnName("BOL_LOCADOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locatario")
                        .HasColumnName("BOL_LOCATARIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumBoleto")
                        .HasColumnName("BOL_NUMBOL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PagBoleto")
                        .HasColumnName("BOL_PAGBOL")
                        .HasColumnType("int");

                    b.Property<DateTime>("PeriodoFim")
                        .HasColumnName("BOL_DTFIM")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PeriodoInicio")
                        .HasColumnName("BOL_DTINI")
                        .HasColumnType("datetime2");

                    b.Property<string>("TipoImovel")
                        .HasColumnName("BOL_TPIMOVEL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TxAdministracao")
                        .HasColumnName("BOL_TXADM")
                        .HasColumnType("float");

                    b.Property<double>("TxDesconto")
                        .HasColumnName("BOL_TXDESC")
                        .HasColumnType("float");

                    b.Property<double>("Valor")
                        .HasColumnName("BOL_VALOR")
                        .HasColumnType("float");

                    b.Property<double>("VlrAdministracao")
                        .HasColumnName("BOL_VLRADM")
                        .HasColumnType("float");

                    b.Property<double>("VlrDesconto")
                        .HasColumnName("BOL_VLRDESC")
                        .HasColumnType("float");

                    b.Property<double>("VlrIptu")
                        .HasColumnName("BOL_VLRIPTU")
                        .HasColumnType("float");

                    b.Property<double>("VlrMulta")
                        .HasColumnName("BOL_VLRMULTA")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("IdContrato");

                    b.ToTable("TB_BOLETO");
                });

            modelBuilder.Entity("Entities.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CLI_ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnName("CLI_BAIRRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnName("CLI_CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnName("CLI_CELULAR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnName("CLI_CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnName("CLI_CIDADE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnName("CLI_COMPL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento2")
                        .HasColumnName("CLI_COMPL2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnName("CLI_DTALT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("CLI_DTCAD")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnName("CLI_EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lougradouro")
                        .HasColumnName("CLI_LOUGRADOURO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnName("CLI_NOME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroImovel")
                        .HasColumnName("CLI_NUMIMOV")
                        .HasColumnType("int");

                    b.Property<string>("TelefoneFixo")
                        .HasColumnName("CLI_TELFIXO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoCliente")
                        .HasColumnName("CLI_TPCLIENTE")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .HasColumnName("CLI_UF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TB_CLIENTE");
                });

            modelBuilder.Entity("Entities.Entities.Contrato", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnName("CTR_ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bairro")
                        .HasColumnName("CTR_BAIRRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnName("CTR_CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnName("CTR_CIDADE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnName("CTR_COMPL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento2")
                        .HasColumnName("CTR_COMPL2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnName("CTR_DTENTRADA")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnName("CTR_DTSAIDA")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiaPagamento")
                        .HasColumnName("CTR_DIAPAG")
                        .HasColumnType("int");

                    b.Property<string>("Locador")
                        .HasColumnName("CTR_LOCADOR")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Locatario")
                        .HasColumnName("CTR_LOCATARIO")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Lougradouro")
                        .HasColumnName("CTR_LOUGRADOURO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroImovel")
                        .HasColumnName("CTR_NUMIMOV")
                        .HasColumnType("int");

                    b.Property<int>("QtaMeses")
                        .HasColumnName("CTR_QTAMESES")
                        .HasColumnType("int");

                    b.Property<int>("SituacaoContrato")
                        .HasColumnName("CTR_SITUACAO")
                        .HasColumnType("int");

                    b.Property<string>("TipoImovel")
                        .HasColumnName("CTR_TIPO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnName("CTR_UF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Valor")
                        .HasColumnName("CTR_VALOR")
                        .HasColumnType("float");

                    b.Property<double>("VlrIptu")
                        .HasColumnName("CTR_VLRIPTU")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("UserId");

                    b.ToTable("TB_CONTRATO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Entities.Entities.Anuncio", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Entities.Entities.Boleto", b =>
                {
                    b.HasOne("Entities.Entities.Contrato", "Contrato")
                        .WithMany()
                        .HasForeignKey("IdContrato");
                });

            modelBuilder.Entity("Entities.Entities.Cliente", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Entities.Entities.Contrato", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
