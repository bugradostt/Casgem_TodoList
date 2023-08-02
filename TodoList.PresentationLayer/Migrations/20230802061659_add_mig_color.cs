using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoList.DataAccessLayer.Migrations
{
    public partial class add_mig_color : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TodoColor",
                table: "Todos",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TodoColor",
                table: "Todos");
        }
    }
}
