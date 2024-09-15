using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATA.Migrations
{
    /// <inheritdoc />
    public partial class xxxx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_Categories_CategoryId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_CategoryId",
                table: "BlogPost");

            migrationBuilder.AddColumn<int>(
                name: "CategoryDtoId",
                table: "BlogPost",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_CategoryDtoId",
                table: "BlogPost",
                column: "CategoryDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_Categories_CategoryDtoId",
                table: "BlogPost",
                column: "CategoryDtoId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPost_Categories_CategoryDtoId",
                table: "BlogPost");

            migrationBuilder.DropIndex(
                name: "IX_BlogPost_CategoryDtoId",
                table: "BlogPost");

            migrationBuilder.DropColumn(
                name: "CategoryDtoId",
                table: "BlogPost");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPost_CategoryId",
                table: "BlogPost",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPost_Categories_CategoryId",
                table: "BlogPost",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
