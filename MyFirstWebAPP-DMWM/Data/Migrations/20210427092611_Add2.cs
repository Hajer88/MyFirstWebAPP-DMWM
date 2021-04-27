using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstWebAPP_DMWM.Data.Migrations
{
    public partial class Add2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Categories");
        }
    }
}
