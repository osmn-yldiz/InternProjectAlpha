using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9450a960-4f4c-4967-84c7-1e9f5781dd00"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 20, 8, 45, 9, 625, DateTimeKind.Utc).AddTicks(3021), new DateTime(2024, 7, 20, 8, 45, 9, 625, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ee423d32-2a02-49c0-a70d-eeaeadfcf5c2"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 20, 8, 45, 9, 626, DateTimeKind.Utc).AddTicks(9801), new DateTime(2024, 7, 20, 8, 45, 9, 626, DateTimeKind.Utc).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e378b2e-0b75-4a4f-b4f1-881419799561"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 20, 8, 45, 9, 627, DateTimeKind.Utc).AddTicks(1277), new DateTime(2024, 7, 20, 8, 45, 9, 627, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e60eb9a-9e7f-4a3d-8bbc-611bd5798a18"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 20, 8, 45, 9, 627, DateTimeKind.Utc).AddTicks(5555), new DateTime(2024, 7, 20, 8, 45, 9, 627, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e7d477c-7b2b-4bd1-b120-89b3f189340e"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 20, 8, 45, 9, 627, DateTimeKind.Utc).AddTicks(7059), new DateTime(2024, 7, 20, 8, 45, 9, 627, DateTimeKind.Utc).AddTicks(7059) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("9450a960-4f4c-4967-84c7-1e9f5781dd00"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 18, 12, 9, 42, 6, DateTimeKind.Utc).AddTicks(7318), new DateTime(2024, 7, 18, 12, 9, 42, 6, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ee423d32-2a02-49c0-a70d-eeaeadfcf5c2"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 18, 12, 9, 42, 8, DateTimeKind.Utc).AddTicks(8346), new DateTime(2024, 7, 18, 12, 9, 42, 8, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5e378b2e-0b75-4a4f-b4f1-881419799561"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(157), new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e60eb9a-9e7f-4a3d-8bbc-611bd5798a18"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(5328), new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e7d477c-7b2b-4bd1-b120-89b3f189340e"),
                columns: new[] { "CreatedDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(7325), new DateTime(2024, 7, 18, 12, 9, 42, 9, DateTimeKind.Utc).AddTicks(7326) });
        }
    }
}
