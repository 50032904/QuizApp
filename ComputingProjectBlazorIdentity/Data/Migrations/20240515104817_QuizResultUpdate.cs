using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputingProjectBlazorIdentity.Migrations
{
    /// <inheritdoc />
    public partial class QuizResultUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizResults_AspNetUsers_UserId",
                table: "QuizResults");

            migrationBuilder.DropIndex(
                name: "IX_QuizResults_UserId",
                table: "QuizResults");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "QuizResults",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "QuizResults",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizResults_ApplicationUserId",
                table: "QuizResults",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizResults_AspNetUsers_ApplicationUserId",
                table: "QuizResults",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuizResults_AspNetUsers_ApplicationUserId",
                table: "QuizResults");

            migrationBuilder.DropIndex(
                name: "IX_QuizResults_ApplicationUserId",
                table: "QuizResults");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "QuizResults");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "QuizResults",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_QuizResults_UserId",
                table: "QuizResults",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuizResults_AspNetUsers_UserId",
                table: "QuizResults",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
