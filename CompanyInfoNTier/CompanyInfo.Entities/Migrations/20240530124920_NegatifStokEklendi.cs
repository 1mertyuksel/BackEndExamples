using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class NegatifStokEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NegatifStokCalis",
                table: "Urunler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 30, 15, 49, 19, 333, DateTimeKind.Local).AddTicks(9094));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NegatifStokCalis",
                table: "Urunler");

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(3429));
        }
    }
}
