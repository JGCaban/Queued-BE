using Microsoft.EntityFrameworkCore.Migrations;

namespace RedStarter.Database.Migrations
{
    public partial class propertyupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExpectedWait",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TypeOfEvent",
                table: "EventTableAccess",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpectedWait",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "EventTableAccess");

            migrationBuilder.DropColumn(
                name: "TypeOfEvent",
                table: "EventTableAccess");
        }
    }
}
