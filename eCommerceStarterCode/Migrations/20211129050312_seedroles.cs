using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class seedroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85197de-2346-492e-861e-08b0370b485f",
                column: "ConcurrencyStamp",
                value: "223becfb-6697-401b-9207-0233ec6f690e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0",
                column: "ConcurrencyStamp",
                value: "8d3220b7-b21e-41ad-8f41-da445207da21");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c073f42c-79e8-41a6-a5d7-0ed41ae70001", "a3b18eaf-173a-4576-9d73-8e7be47fdd78", "Customer", "CUSTOMER" },
                    { "a85197de-2346-492e-861e-08b0370b0002", "aeae5aca-88a9-4e47-b0ee-1f4d6a5054e2", "Seller", "SELLER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85197de-2346-492e-861e-08b0370b0002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c073f42c-79e8-41a6-a5d7-0ed41ae70001");

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
    }
}
