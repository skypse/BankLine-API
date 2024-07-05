using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankLine_API.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tab_conta",
                columns: table => new
                {
                    conta_numero = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    conta_saldo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_conta", x => x.conta_numero);
                });

            migrationBuilder.CreateTable(
                name: "tab_movimentacao",
                columns: table => new
                {
                    movimentacao_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movimentacao_dt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    movimentacao_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    movimentacao_valor = table.Column<int>(type: "int", nullable: false),
                    movimentacao_tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_movimentacao", x => x.movimentacao_id);
                });

            migrationBuilder.CreateTable(
                name: "tab_correntista",
                columns: table => new
                {
                    correntista_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correntista_cpf = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    correntista_nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    conta_numero_fk = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tab_correntista", x => x.correntista_id);
                    table.ForeignKey(
                        name: "FK_tab_correntista_tab_conta_conta_numero_fk",
                        column: x => x.conta_numero_fk,
                        principalTable: "tab_conta",
                        principalColumn: "conta_numero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tab_correntista_conta_numero_fk",
                table: "tab_correntista",
                column: "conta_numero_fk",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tab_correntista");

            migrationBuilder.DropTable(
                name: "tab_movimentacao");

            migrationBuilder.DropTable(
                name: "tab_conta");
        }
    }
}
