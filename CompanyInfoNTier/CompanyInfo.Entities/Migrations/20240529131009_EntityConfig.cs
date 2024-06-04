using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class EntityConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "Urunler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunAdi",
                table: "Urunler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Tedarikciler",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SirketAdi",
                table: "Tedarikciler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "KategoriAdi",
                table: "Kategoriler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BirimAdi",
                table: "Birimler",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Birimler",
                columns: new[] { "Id", "BirimAdi", "CreateDate" },
                values: new object[,]
                {
                    { 1, "Adet", new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9211) },
                    { 2, "Cm", new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9212) },
                    { 3, "Gram", new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9214) },
                    { 4, "Miligram", new DateTime(2024, 5, 29, 16, 10, 9, 534, DateTimeKind.Local).AddTicks(9215) }
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Aciklama", "CreateDate", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1666), "Gida" },
                    { 2, null, new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1667), "Tekstil" },
                    { 3, null, new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1669), "Eletronik" },
                    { 4, null, new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(1670), "Otomotiv" }
                });

            migrationBuilder.InsertData(
                table: "Tedarikciler",
                columns: new[] { "Id", "CreateDate", "SirketAdi", "VergiNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(3426), "Abc", "123" },
                    { 2, new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(3428), "Asd", "456" },
                    { 3, new DateTime(2024, 5, 29, 16, 10, 9, 535, DateTimeKind.Local).AddTicks(3429), "Qwe", "7789" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_UrunKodu",
                table: "Urunler",
                column: "UrunKodu",
                unique: true,
                filter: "[UrunKodu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tedarikciler_VergiNo",
                table: "Tedarikciler",
                column: "VergiNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler",
                column: "KategoriAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Birimler_BirimAdi",
                table: "Birimler",
                column: "BirimAdi",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Urunler_UrunKodu",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Tedarikciler_VergiNo",
                table: "Tedarikciler");

            migrationBuilder.DropIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Birimler_BirimAdi",
                table: "Birimler");

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Birimler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tedarikciler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunAdi",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "VergiNo",
                table: "Tedarikciler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SirketAdi",
                table: "Tedarikciler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "KategoriAdi",
                table: "Kategoriler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BirimAdi",
                table: "Birimler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
