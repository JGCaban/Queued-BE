using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class ownerIdToEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EventTitle",
                table: "EventTableAccess",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "EventTableAccess");

            migrationBuilder.AlterColumn<string>(
                name: "EventTitle",
                table: "EventTableAccess",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
