using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationHelpdesk.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ticketCreates_TicketStatus_StatusId",
                table: "ticketCreates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketStatus",
                table: "TicketStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ticekLists",
                table: "ticekLists");

            migrationBuilder.RenameTable(
                name: "TicketStatus",
                newName: "ticketStatus");

            migrationBuilder.RenameTable(
                name: "ticekLists",
                newName: "ticketLists");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ticketStatus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ticketStatus",
                table: "ticketStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ticketLists",
                table: "ticketLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticketCreates_ticketStatus_StatusId",
                table: "ticketCreates",
                column: "StatusId",
                principalTable: "ticketStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ticketCreates_ticketStatus_StatusId",
                table: "ticketCreates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ticketStatus",
                table: "ticketStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ticketLists",
                table: "ticketLists");

            migrationBuilder.RenameTable(
                name: "ticketStatus",
                newName: "TicketStatus");

            migrationBuilder.RenameTable(
                name: "ticketLists",
                newName: "ticekLists");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "TicketStatus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketStatus",
                table: "TicketStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ticekLists",
                table: "ticekLists",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ticketCreates_TicketStatus_StatusId",
                table: "ticketCreates",
                column: "StatusId",
                principalTable: "TicketStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
