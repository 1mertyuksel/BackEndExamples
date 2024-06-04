using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyInfo.Entities.Migrations
{
    /// <inheritdoc />
    public partial class createDb : Migration
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
                    BirimAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    SirketAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrunKodu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    Adet = table.Column<double>(type: "float", nullable: true),
                    BirimId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_KategoriUrun_UrunlerId",
                table: "KategoriUrun",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_TedarikciUrun_UrunlerId",
                table: "TedarikciUrun",
                column: "UrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BirimId",
                table: "Urunler",
                column: "BirimId");
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
