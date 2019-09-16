using Microsoft.EntityFrameworkCore.Migrations;

namespace safari_vacation.Migrations
{
    public partial class AddedAnimalsToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SeenAnimal",
                table: "SeenAnimal");

            migrationBuilder.RenameTable(
                name: "SeenAnimal",
                newName: "Animal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal",
                table: "Animal",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal",
                table: "Animal");

            migrationBuilder.RenameTable(
                name: "Animal",
                newName: "SeenAnimal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeenAnimal",
                table: "SeenAnimal",
                column: "Id");
        }
    }
}
