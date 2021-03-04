using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogService.Migrations
{
    public partial class UpdateModelPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PostDescription",
                table: "Posts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Comment", "PostId" },
                values: new object[,]
                {
                    { new Guid("c5a6f484-0579-47ec-b84e-2910adbc60ee"), "Comment test 1", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d") },
                    { new Guid("edb1e52f-0527-450c-8a84-cbf3a236a453"), "Comment test 2", new Guid("8c8bffc2-9347-4958-a27d-1f3085e7e98d") },
                    { new Guid("63c4248d-ae75-48db-b862-bf869dc88ed3"), "Comment test 2", new Guid("bad5b4e7-b313-4b22-ab54-4c434c0d5a14") }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AuthorName", "PostDescription", "State", "SubmitDate" },
                values: new object[,]
                {
                    { new Guid("dee7944c-d9da-4050-ac6e-2f4d50b94ec5"), "sergio.com", null, 3, new DateTime(2021, 3, 2, 20, 59, 9, 875, DateTimeKind.Local).AddTicks(7003) },
                    { new Guid("7a268516-735d-4121-b461-ed0fdbffb215"), "sergio.com", null, 1, new DateTime(2021, 3, 2, 20, 59, 9, 879, DateTimeKind.Local).AddTicks(2781) },
                    { new Guid("946a1303-adc2-4ba7-9433-644d1f0102ee"), "ser.com", null, 3, new DateTime(2021, 3, 2, 20, 59, 9, 879, DateTimeKind.Local).AddTicks(2860) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("63c4248d-ae75-48db-b862-bf869dc88ed3"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c5a6f484-0579-47ec-b84e-2910adbc60ee"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("edb1e52f-0527-450c-8a84-cbf3a236a453"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("7a268516-735d-4121-b461-ed0fdbffb215"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("946a1303-adc2-4ba7-9433-644d1f0102ee"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("dee7944c-d9da-4050-ac6e-2f4d50b94ec5"));

            migrationBuilder.DropColumn(
                name: "PostDescription",
                table: "Posts");

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
    }
}
