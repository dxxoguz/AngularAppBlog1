using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATA.Migrations
{
    /// <inheritdoc />
    public partial class fjfpeppgdvpbp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Settings_Users_UserId",
                table: "User_Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Settings",
                table: "User_Settings");

            migrationBuilder.RenameTable(
                name: "User_Settings",
                newName: "UserSettings");

            migrationBuilder.RenameIndex(
                name: "IX_User_Settings_UserId",
                table: "UserSettings",
                newName: "IX_UserSettings_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSettings",
                table: "UserSettings",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mission_Vision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Executive = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutUsDtoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMember_AboutUs_AboutUsDtoId",
                        column: x => x.AboutUsDtoId,
                        principalTable: "AboutUs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_AboutUsDtoId",
                table: "TeamMember",
                column: "AboutUsDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSettings_Users_UserId",
                table: "UserSettings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSettings_Users_UserId",
                table: "UserSettings");

            migrationBuilder.DropTable(
                name: "TeamMember");

            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSettings",
                table: "UserSettings");

            migrationBuilder.RenameTable(
                name: "UserSettings",
                newName: "User_Settings");

            migrationBuilder.RenameIndex(
                name: "IX_UserSettings_UserId",
                table: "User_Settings",
                newName: "IX_User_Settings_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Settings",
                table: "User_Settings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Settings_Users_UserId",
                table: "User_Settings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
