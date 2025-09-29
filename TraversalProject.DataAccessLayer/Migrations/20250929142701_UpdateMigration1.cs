using Microsoft.EntityFrameworkCore.Migrations;

namespace TraversalProject.DataAccessLayer.Migrations
{
    public partial class UpdateMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Newsletters",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Newsletters");
        }
    }
}
