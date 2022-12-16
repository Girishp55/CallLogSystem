using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CallLogSystem.Migrations
{
    /// <inheritdoc />
    public partial class addedActionTakenandIssueResolved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionTaken",
                table: "CallLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IssueResolved",
                table: "CallLogs",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionTaken",
                table: "CallLogs");

            migrationBuilder.DropColumn(
                name: "IssueResolved",
                table: "CallLogs");
        }
    }
}
