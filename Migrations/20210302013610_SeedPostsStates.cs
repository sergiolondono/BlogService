using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogService.Migrations
{
    public partial class SeedPostsStates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    SubmitDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "Comment", "State", "SubmitDate" },
                values: new object[,]
                {
                    { new Guid("347c3a53-1172-4e58-a874-4490d8bbbb9d"), "sergio.com", "Comment Test", 1, new DateTime(2021, 3, 1, 20, 36, 9, 239, DateTimeKind.Local).AddTicks(5190) },
                    { new Guid("9b5e98db-442f-4a9b-9b8e-5f8e717fe396"), "sergio.com", "Comment Test two", 1, new DateTime(2021, 3, 1, 20, 36, 9, 245, DateTimeKind.Local).AddTicks(2998) },
                    { new Guid("12abffe7-9f3f-4593-9527-7569eb4b343e"), "ser.com", "Comment Test Three", 1, new DateTime(2021, 3, 1, 20, 36, 9, 245, DateTimeKind.Local).AddTicks(3064) }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "PendingToApproval" },
                    { 2, "Reject" },
                    { 3, "Approval" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
