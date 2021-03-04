using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogService.Migrations
{
    public partial class CommentsSeed4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("566c14e1-9ad4-4df4-b41e-1b077a1ebda5"), "Comment test 1", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d") },
                    { new Guid("b94b93a8-43aa-40bd-ae10-67db49831bd1"), "Comment test 2", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d") },
                    { new Guid("cac98734-23b6-4b2d-be27-ac33f7c63a7a"), "Comment test 2", new Guid("bad5b4e7-b313-4b22-ab54-4c434c0d5a14") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "State", "SubmitDate" },
                values: new object[,]
                {
                    { new Guid("98552a20-36ec-4b42-9f95-c9b6136dcce5"), "sergio.com", 3, new DateTime(2021, 3, 2, 16, 53, 18, 503, DateTimeKind.Local).AddTicks(4061) },
                    { new Guid("9334182a-adf6-4d07-a31b-ac51e6ef747e"), "sergio.com", 1, new DateTime(2021, 3, 2, 16, 53, 18, 506, DateTimeKind.Local).AddTicks(2957) },
                    { new Guid("6f0ccde5-8eef-4753-8cbb-f8c1d9a2c127"), "ser.com", 3, new DateTime(2021, 3, 2, 16, 53, 18, 506, DateTimeKind.Local).AddTicks(3046) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("566c14e1-9ad4-4df4-b41e-1b077a1ebda5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b94b93a8-43aa-40bd-ae10-67db49831bd1"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("cac98734-23b6-4b2d-be27-ac33f7c63a7a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6f0ccde5-8eef-4753-8cbb-f8c1d9a2c127"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("9334182a-adf6-4d07-a31b-ac51e6ef747e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("98552a20-36ec-4b42-9f95-c9b6136dcce5"));

            migrationBuilder.AddColumn<Guid>(
                name: "PostsId",
                table: "Comments",
                type: "uniqueidentifier",
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
    }
}
