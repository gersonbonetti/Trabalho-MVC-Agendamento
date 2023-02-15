using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCAgendamentoInfraData.Migrations
{
    /// <inheritdoc />
    public partial class RenameService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceNumbe",
                table: "Services",
                newName: "ServiceNumber");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Em atendimento");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Aguardando confirmação");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Marcada");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Atendido");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Arquivado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceNumber",
                table: "Services",
                newName: "ServiceNumbe");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "In attendance");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Waiting confirmation");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Marked");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Answered");

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Filed");
        }
    }
}
