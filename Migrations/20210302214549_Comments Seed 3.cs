using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogService.Migrations
{
    public partial class CommentsSeed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "PostsId",
                table: "Comments",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Comment", "PostId", "PostsId" },
                values: new object[,]
                {
                    { new Guid("fde07bf3-295e-4858-a704-c27f969e952b"), "Comment test 1", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d"), null },
                    { new Guid("40c0a42b-40b1-40cb-a64b-12241cc6401b"), "Comment test 2", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d"), null },
                    { new Guid("4bf6aff2-82a6-436b-a28b-d7baf0536d44"), "Comment test 2", new Guid("bad5b4e7-b313-4b22-ab54-4c434c0d5a14"), null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "State", "SubmitDate" },
                values: new object[,]
                {
                    { new Guid("710a5568-8f98-4c01-a943-4ca9ebda3eb7"), "sergio.com", 3, new DateTime(2021, 3, 2, 16, 45, 48, 172, DateTimeKind.Local).AddTicks(536) },
                    { new Guid("acdd3d34-4d29-4918-b4a2-2dd7c08ac352"), "sergio.com", 1, new DateTime(2021, 3, 2, 16, 45, 48, 178, DateTimeKind.Local).AddTicks(6662) },
                    { new Guid("ef31b06a-752b-4328-ab1e-80fd0189154d"), "ser.com", 3, new DateTime(2021, 3, 2, 16, 45, 48, 178, DateTimeKind.Local).AddTicks(6737) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostsId",
                table: "Comments",
                column: "PostsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostsId",
                table: "Comments",
                column: "PostsId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostsId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_PostsId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("40c0a42b-40b1-40cb-a64b-12241cc6401b"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4bf6aff2-82a6-436b-a28b-d7baf0536d44"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("fde07bf3-295e-4858-a704-c27f969e952b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("710a5568-8f98-4c01-a943-4ca9ebda3eb7"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("acdd3d34-4d29-4918-b4a2-2dd7c08ac352"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("ef31b06a-752b-4328-ab1e-80fd0189154d"));

            migrationBuilder.DropColumn(
                name: "PostsId",
                table: "Comments");

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
    }
}
