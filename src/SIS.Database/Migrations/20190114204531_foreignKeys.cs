using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class foreignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JumperPersonEntityId",
                table: "EventTableAccess",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonEntityId",
                table: "EventTableAccess",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventTableAccess_JumperPersonEntityId",
                table: "EventTableAccess",
                column: "JumperPersonEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTableAccess_PersonEntityId",
                table: "EventTableAccess",
                column: "PersonEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventTableAccess_PersonTableAccess_JumperPersonEntityId",
                table: "EventTableAccess",
                column: "JumperPersonEntityId",
                principalTable: "PersonTableAccess",
                principalColumn: "PersonEntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventTableAccess_PersonTableAccess_PersonEntityId",
                table: "EventTableAccess",
                column: "PersonEntityId",
                principalTable: "PersonTableAccess",
                principalColumn: "PersonEntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventTableAccess_PersonTableAccess_JumperPersonEntityId",
                table: "EventTableAccess");

            migrationBuilder.DropForeignKey(
                name: "FK_EventTableAccess_PersonTableAccess_PersonEntityId",
                table: "EventTableAccess");

            migrationBuilder.DropIndex(
                name: "IX_EventTableAccess_JumperPersonEntityId",
                table: "EventTableAccess");

            migrationBuilder.DropIndex(
                name: "IX_EventTableAccess_PersonEntityId",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "JumperPersonEntityId",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "PersonEntityId",
                table: "EventTableAccess");
        }
    }
}
