using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Data.Migrations
{
    public partial class AddingCreatedOnToHouseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("60cd22dc-a421-438f-82f8-5c26ddc005f9"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Houses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0d2c241-030f-4903-ba8d-4f539de87ead", "AQAAAAEAACcQAAAAEOQ+GMZiuxEGzciqbLFXcqwMxLmaPwoBmqUr/qIWdFaQFMVCprlnWR9yVJpng1T4zw==", "74b5c4fc-f7c3-489f-a332-a587a5f9a4cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88bef8dc-dae5-4be6-956a-11810887edf1", "AQAAAAEAACcQAAAAEL2/ZYgNjPUqG+QIr7NGGxRGEu4N540cERYZmCH6mewMlLCZPtjmGf03EZAleOgJyw==", "27478716-4c3a-46bf-9d4a-d5d52c676754" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("70be8ec9-abfe-4eb9-8a86-45d6b036c1d8"),
                column: "CreatedOn",
                value: new DateTime(2023, 7, 21, 11, 42, 41, 797, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("b87de45d-e5a8-4098-af9f-ab1e5514e18d"),
                column: "CreatedOn",
                value: new DateTime(2023, 7, 21, 11, 42, 41, 797, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "CreatedOn", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("421c8437-484a-4228-bd72-2926e17258f4"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("dea12856-c198-4129-b3f3-b893d8395082"), 2, new DateTime(2023, 7, 21, 11, 42, 41, 797, DateTimeKind.Utc).AddTicks(8720), "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a & o = &hp = 1", 1200.00m, new Guid("00000000-0000-0000-0000-000000000000"), "Family House Comfort" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: new Guid("421c8437-484a-4228-bd72-2926e17258f4"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9fd2762-38f8-4abc-a775-ff682515d4ae", "AQAAAAEAACcQAAAAEGFnojviFVA6N2iVNmEU199m5R3dODIE+hSfhgZDODC6N8RFtQLK5wvQXh2XSqZdEg==", "49e346c9-9eae-4cb3-8231-dfca4a2a0195" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e613b8f7-a8c6-4e61-afca-a08f0103c477", "AQAAAAEAACcQAAAAEGhTJ5jde+yjIq9ZTYLGStK9mOtUigc+3uj/gKBiI+BMfSilEO2FROeeIvKpK1/VXg==", "1ece5fe9-da85-4c62-8544-19e49f7a4dfd" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[] { new Guid("60cd22dc-a421-438f-82f8-5c26ddc005f9"), "Near the Sea Garden in Burgas, Bulgaria", new Guid("dea12856-c198-4129-b3f3-b893d8395082"), 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a & o = &hp = 1", 1200.00m, new Guid("00000000-0000-0000-0000-000000000000"), "Family House Comfort" });
        }
    }
}
