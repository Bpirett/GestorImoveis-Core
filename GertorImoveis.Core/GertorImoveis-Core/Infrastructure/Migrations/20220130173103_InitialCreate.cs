using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    USR_CPF = table.Column<string>(maxLength: 16, nullable: true),
                    USR_IDADE = table.Column<string>(nullable: true),
                    USR_NOME = table.Column<string>(nullable: true),
                    USR_TELEFONE = table.Column<string>(maxLength: 20, nullable: true),
                    USR_CELULAR = table.Column<string>(maxLength: 20, nullable: true),
                    USR_BAIRRO = table.Column<string>(nullable: true),
                    USR_CEP = table.Column<string>(nullable: true),
                    USR_CIDADE = table.Column<string>(nullable: true),
                    USR_COMPL = table.Column<string>(nullable: true),
                    USR_COMPL2 = table.Column<string>(nullable: true),
                    USR_ENDERECO = table.Column<string>(nullable: true),
                    USR_NUMIMOV = table.Column<int>(nullable: false),
                    USR_UF = table.Column<string>(nullable: true),
                    USR_TPUSU = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ANUNCIO",
                columns: table => new
                {
                    ANC_ID = table.Column<string>(nullable: false),
                    ANC_VALOR = table.Column<double>(nullable: false),
                    ANC_END = table.Column<string>(nullable: true),
                    ANC_VLRIPTU = table.Column<double>(nullable: false),
                    ANC_TPIMOVEL = table.Column<string>(nullable: true),
                    ANC_TPNEG = table.Column<string>(nullable: true),
                    ANC_QTDORMI = table.Column<int>(nullable: false),
                    ANC_QTSUITES = table.Column<int>(nullable: false),
                    ANC_QTVAGAS = table.Column<int>(nullable: false),
                    ANC_AREA = table.Column<int>(nullable: false),
                    ANC_CIDADE = table.Column<string>(nullable: true),
                    ANC_BAIRRO = table.Column<string>(nullable: true),
                    ANC_DESCRICAO = table.Column<string>(maxLength: 200000, nullable: true),
                    ANC_DTCAD = table.Column<DateTime>(nullable: false),
                    ANC_ATIVO = table.Column<string>(nullable: true),
                    ANC_DTATUALI = table.Column<DateTime>(nullable: false),
                    ANC_PERMUTA = table.Column<bool>(nullable: false),
                    ANC_CHURRASQUEIRA = table.Column<bool>(nullable: false),
                    ANC_PISCINA = table.Column<bool>(nullable: false),
                    ANC_BRINQUE = table.Column<bool>(nullable: false),
                    ANC_PLAYGROUD = table.Column<bool>(nullable: false),
                    ANC_POLIESP = table.Column<bool>(nullable: false),
                    ANC_GISNASTICA = table.Column<bool>(nullable: false),
                    ANC_SFESTA = table.Column<bool>(nullable: false),
                    ANC_SJOGOS = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ANUNCIO", x => x.ANC_ID);
                    table.ForeignKey(
                        name: "FK_TB_ANUNCIO_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_CLIENTE",
                columns: table => new
                {
                    CLI_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLI_NOME = table.Column<string>(nullable: true),
                    CLI_CPF = table.Column<string>(nullable: true),
                    CLI_TELFIXO = table.Column<string>(nullable: true),
                    CLI_CELULAR = table.Column<string>(nullable: true),
                    CLI_EMAIL = table.Column<string>(nullable: true),
                    CLI_TPCLIENTE = table.Column<int>(nullable: false),
                    CLI_BAIRRO = table.Column<string>(nullable: true),
                    CLI_CEP = table.Column<string>(nullable: true),
                    CLI_CIDADE = table.Column<string>(nullable: true),
                    CLI_COMPL = table.Column<string>(nullable: true),
                    CLI_COMPL2 = table.Column<string>(nullable: true),
                    CLI_LOUGRADOURO = table.Column<string>(nullable: true),
                    CLI_NUMIMOV = table.Column<int>(nullable: false),
                    CLI_UF = table.Column<string>(nullable: true),
                    CLI_DTCAD = table.Column<DateTime>(nullable: false),
                    CLI_DTALT = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTE", x => x.CLI_ID);
                    table.ForeignKey(
                        name: "FK_TB_CLIENTE_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_CONTRATO",
                columns: table => new
                {
                    CTR_ID = table.Column<string>(nullable: false),
                    CTR_LOCATARIO = table.Column<string>(maxLength: 200, nullable: true),
                    CTR_LOCADOR = table.Column<string>(maxLength: 200, nullable: true),
                    CTR_VALOR = table.Column<double>(nullable: false),
                    CTR_DIAPAG = table.Column<int>(nullable: false),
                    CTR_DTENTRADA = table.Column<DateTime>(nullable: false),
                    CTR_DTSAIDA = table.Column<DateTime>(nullable: false),
                    CTR_QTAMESES = table.Column<int>(nullable: false),
                    CTR_VLRIPTU = table.Column<double>(nullable: false),
                    CTR_TIPO = table.Column<string>(nullable: true),
                    CTR_SITUACAO = table.Column<int>(nullable: false),
                    CTR_BAIRRO = table.Column<string>(nullable: true),
                    CTR_CEP = table.Column<string>(nullable: true),
                    CTR_CIDADE = table.Column<string>(nullable: true),
                    CTR_COMPL = table.Column<string>(nullable: true),
                    CTR_COMPL2 = table.Column<string>(nullable: true),
                    CTR_LOUGRADOURO = table.Column<string>(nullable: true),
                    CTR_NUMIMOV = table.Column<int>(nullable: false),
                    CTR_UF = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CONTRATO", x => x.CTR_ID);
                    table.ForeignKey(
                        name: "FK_TB_CONTRATO_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_BOLETO",
                columns: table => new
                {
                    BOL_ID = table.Column<string>(nullable: false),
                    IdContrato = table.Column<string>(nullable: true),
                    BOL_NUMBOL = table.Column<string>(nullable: true),
                    BOL_LOCATARIO = table.Column<string>(nullable: true),
                    BOL_LOCADOR = table.Column<string>(nullable: true),
                    BOL_TPIMOVEL = table.Column<string>(nullable: true),
                    BOL_VALOR = table.Column<double>(nullable: false),
                    BOL_ENDERECO = table.Column<string>(nullable: true),
                    BOL_DTVENC = table.Column<DateTime>(nullable: false),
                    BOL_JRMULTA = table.Column<double>(nullable: false),
                    BOL_VLRMULTA = table.Column<double>(nullable: false),
                    BOL_VLRIPTU = table.Column<double>(nullable: false),
                    BOL_TXDESC = table.Column<double>(nullable: false),
                    BOL_VLRDESC = table.Column<double>(nullable: false),
                    BOL_PAGBOL = table.Column<int>(nullable: false),
                    BOL_DTPAG = table.Column<DateTime>(nullable: false),
                    BOL_TXADM = table.Column<double>(nullable: false),
                    BOL_VLRADM = table.Column<double>(nullable: false),
                    BOL_DTINI = table.Column<DateTime>(nullable: false),
                    BOL_DTFIM = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_BOLETO", x => x.BOL_ID);
                    table.ForeignKey(
                        name: "FK_TB_BOLETO_TB_CONTRATO_IdContrato",
                        column: x => x.IdContrato,
                        principalTable: "TB_CONTRATO",
                        principalColumn: "CTR_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANUNCIO_UserId",
                table: "TB_ANUNCIO",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_BOLETO_IdContrato",
                table: "TB_BOLETO",
                column: "IdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTE_UserId",
                table: "TB_CLIENTE",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CONTRATO_UserId",
                table: "TB_CONTRATO",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "TB_ANUNCIO");

            migrationBuilder.DropTable(
                name: "TB_BOLETO");

            migrationBuilder.DropTable(
                name: "TB_CLIENTE");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TB_CONTRATO");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
