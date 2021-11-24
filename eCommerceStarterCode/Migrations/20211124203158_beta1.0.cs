using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class beta10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85197de-2346-492e-861e-08b0370b485f",
                column: "ConcurrencyStamp",
                value: "ab51f1aa-a6ff-4668-9ca9-9782c4b72f8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0",
                column: "ConcurrencyStamp",
                value: "b957ca06-be2e-40a7-8e58-6f136f8bd5bc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85197de-2346-492e-861e-08b0370b485f",
                column: "ConcurrencyStamp",
                value: "04795ff8-2147-4bd0-a060-981db2bbc068");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0",
                column: "ConcurrencyStamp",
                value: "b3d1d346-0f37-4031-a087-6c54f9cbe73c");
        }
    }
}
