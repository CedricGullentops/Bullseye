using Microsoft.EntityFrameworkCore.Migrations;

namespace FysicsLeague.Migrations
{
    public partial class AddPrefixToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prefixes",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefixes", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prefixes");
        }
    }
}
