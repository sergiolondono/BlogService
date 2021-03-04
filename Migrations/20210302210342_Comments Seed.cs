using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogService.Migrations
{
    public partial class CommentsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("12abffe7-9f3f-4593-9527-7569eb4b343e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("347c3a53-1172-4e58-a874-4490d8bbbb9d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9b5e98db-442f-4a9b-9b8e-5f8e717fe396"));

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Posts");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PostId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Comment", "PostId" },
                values: new object[,]
                {
                    { new Guid("834d1e8a-859a-480f-965d-4d96f2425b7e"), "Comment test 1", new Guid("347c3a53-1172-4e58-a874-4490d8bbbb9d") },
                    { new Guid("df2ed5d9-4643-457a-83a1-fff81fd98b84"), "Comment test 2", new Guid("347c3a53-1172-4e58-a874-4490d8bbbb9d") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "State", "SubmitDate" },
                values: new object[,]
                {
                    { new Guid("bad5b4e7-b313-4b22-ab54-4c434c0d5a14"), "sergio.com", 1, new DateTime(2021, 3, 2, 16, 3, 40, 626, DateTimeKind.Local).AddTicks(9031) },
                    { new Guid("d431865c-166a-4eec-a938-2fdbf4357cb0"), "sergio.com", 1, new DateTime(2021, 3, 2, 16, 3, 40, 630, DateTimeKind.Local).AddTicks(1385) },
                    { new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d"), "ser.com", 1, new DateTime(2021, 3, 2, 16, 3, 40, 630, DateTimeKind.Local).AddTicks(1478) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("bad5b4e7-b313-4b22-ab54-4c434c0d5a14"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d431865c-166a-4eec-a938-2fdbf4357cb0"));

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "Comment", "State", "SubmitDate" },
                values: new object[] { new Guid("347c3a53-1172-4e58-a874-4490d8bbbb9d"), "sergio.com", "Comment Test", 1, new DateTime(2021, 3, 1, 20, 36, 9, 239, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "Comment", "State", "SubmitDate" },
                values: new object[] { new Guid("9b5e98db-442f-4a9b-9b8e-5f8e717fe396"), "sergio.com", "Comment Test two", 1, new DateTime(2021, 3, 1, 20, 36, 9, 245, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "Comment", "State", "SubmitDate" },
                values: new object[] { new Guid("12abffe7-9f3f-4593-9527-7569eb4b343e"), "ser.com", "Comment Test Three", 1, new DateTime(2021, 3, 1, 20, 36, 9, 245, DateTimeKind.Local).AddTicks(3064) });
        }
    }
}
