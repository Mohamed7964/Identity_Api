using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddLevelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_LevelId",
                table: "Users",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Levels_LevelId",
                table: "Users",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Levels_LevelId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropIndex(
                name: "IX_Users_LevelId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Users");
        }
    }
}
