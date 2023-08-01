using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoList.DataAccessLayer.Migrations
{
    public partial class mig_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TodoStatus",
                table: "Todos",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TodoStatus",
                table: "Todos");
        }
    }
}
