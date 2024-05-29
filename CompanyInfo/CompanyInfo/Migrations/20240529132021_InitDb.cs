using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyInfo.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    Adet = table.Column<double>(type: "float", nullable: true),
                    BirimId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Birimler_BirimId",
                        column: x => x.BirimId,
                        principalTable: "Birimler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KategoriUrun",
                columns: table => new
                {
                    KategorilerId = table.Column<int>(type: "int", nullable: false),
                    UrunlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriUrun", x => new { x.KategorilerId, x.UrunlerId });
                    table.ForeignKey(
                        name: "FK_KategoriUrun_Kategoriler_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriUrun_Urunler_UrunlerId",
                        column: x => x.UrunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TedarikciUrun",
                columns: table => new
                {
                    TedarikcilerId = table.Column<int>(type: "int", nullable: false),
                    UrunlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TedarikciUrun", x => new { x.TedarikcilerId, x.UrunlerId });
                    table.ForeignKey(
                        name: "FK_TedarikciUrun_Tedarikciler_TedarikcilerId",
                        column: x => x.TedarikcilerId,
                        principalTable: "Tedarikciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TedarikciUrun_Urunler_UrunlerId",
                        column: x => x.UrunlerId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Birimler",
                columns: new[] { "Id", "BirimAdi", "DateTime" },
                values: new object[,]
                {
                    { 1, "Adet", new DateTime(2024, 5, 29, 16, 20, 21, 221, DateTimeKind.Local).AddTicks(7879) },
                    { 2, "Cm", new DateTime(2024, 5, 29, 16, 20, 21, 221, DateTimeKind.Local).AddTicks(7881) },
                    { 3, "Gram", new DateTime(2024, 5, 29, 16, 20, 21, 221, DateTimeKind.Local).AddTicks(7883) },
                    { 4, "Miligram", new DateTime(2024, 5, 29, 16, 20, 21, 221, DateTimeKind.Local).AddTicks(7884) }
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Aciklama", "DateTime", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 5, 29, 16, 20, 21, 222, DateTimeKind.Local).AddTicks(826), "Gıda" },
                    { 2, null, new DateTime(2024, 5, 29, 16, 20, 21, 222, DateTimeKind.Local).AddTicks(828), "Tekstil" }
                });

            migrationBuilder.InsertData(
                table: "Tedarikciler",
                columns: new[] { "Id", "DateTime", "SirketAdi", "VergiNo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 29, 16, 20, 21, 222, DateTimeKind.Local).AddTicks(3623), "Abcd", "1234" },
                    { 2, new DateTime(2024, 5, 29, 16, 20, 21, 222, DateTimeKind.Local).AddTicks(3625), "Abc", "123" },
                    { 3, new DateTime(2024, 5, 29, 16, 20, 21, 222, DateTimeKind.Local).AddTicks(3627), "Bca", "321" },
                    { 4, new DateTime(2024, 5, 29, 16, 20, 21, 222, DateTimeKind.Local).AddTicks(3628), "Cba", "213" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Birimler_BirimAdi",
                table: "Birimler",
                column: "BirimAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler",
                column: "KategoriAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KategoriUrun_UrunlerId",
                table: "KategoriUrun",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tedarikciler_VergiNo",
                table: "Tedarikciler",
                column: "VergiNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TedarikciUrun_UrunlerId",
                table: "TedarikciUrun",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BirimId",
                table: "Urunler",
                column: "BirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_UrunKodu",
                table: "Urunler",
                column: "UrunKodu",
                unique: true,
                filter: "[UrunKodu] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriUrun");

            migrationBuilder.DropTable(
                name: "TedarikciUrun");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Birimler");
        }
    }
}
