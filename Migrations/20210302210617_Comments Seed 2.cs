using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogService.Migrations
{
    public partial class CommentsSeed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("834d1e8a-859a-480f-965d-4d96f2425b7e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("df2ed5d9-4643-457a-83a1-fff81fd98b84"));

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

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Comment", "PostId" },
                values: new object[,]
                {
                    { new Guid("95619ba0-b4b4-4435-a582-09f61b45f635"), "Comment test 1", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d") },
                    { new Guid("0891c097-2dab-4880-95e7-629c39f05824"), "Comment test 2", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d") },
                    { new Guid("b327d2fc-de1a-4256-a0f0-cf3afdf535ad"), "Comment test 2", new Guid("bad5b4e7-b313-4b22-ab54-4c434c0d5a14") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "State", "SubmitDate" },
                values: new object[,]
                {
                    { new Guid("efda7b1b-998b-48f0-a150-93870758a8c0"), "sergio.com", 3, new DateTime(2021, 3, 2, 16, 6, 16, 269, DateTimeKind.Local).AddTicks(59) },
                    { new Guid("bd49151b-13f1-4fcd-8e1a-8c5f1db08dbc"), "sergio.com", 1, new DateTime(2021, 3, 2, 16, 6, 16, 273, DateTimeKind.Local).AddTicks(7589) },
                    { new Guid("7a2f3199-aa92-4b31-9459-5de3eae96631"), "ser.com", 3, new DateTime(2021, 3, 2, 16, 6, 16, 273, DateTimeKind.Local).AddTicks(7762) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0891c097-2dab-4880-95e7-629c39f05824"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("95619ba0-b4b4-4435-a582-09f61b45f635"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b327d2fc-de1a-4256-a0f0-cf3afdf535ad"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("7a2f3199-aa92-4b31-9459-5de3eae96631"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("bd49151b-13f1-4fcd-8e1a-8c5f1db08dbc"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("efda7b1b-998b-48f0-a150-93870758a8c0"));

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
    }
}
