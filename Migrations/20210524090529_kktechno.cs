using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YemekHaneTakipOtomasyonu.Migrations
{
    public partial class kktechno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kod_Bolums",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kod_Bolums", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kod_Departmen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kod_Departmen", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kod_Sirkets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kod_Sirkets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "silinen_Personel_Kartlaris",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kartno = table.Column<int>(type: "int", nullable: false),
                    adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sirketid = table.Column<int>(type: "int", nullable: false),
                    departmanid = table.Column<int>(type: "int", nullable: false),
                    bolumid = table.Column<int>(type: "int", nullable: false),
                    unvani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    giristarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cikistarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    kalankontor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_silinen_Personel_Kartlaris", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullanici = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yemek_Oguns",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ogun_ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    basla = table.Column<int>(type: "int", nullable: false),
                    bitis = table.Column<int>(type: "int", nullable: false),
                    ucret = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yemek_Oguns", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personel_Kartlaris",
                columns: table => new
                {
                    kartno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soyadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sirketid = table.Column<int>(type: "int", nullable: false),
                    departmanid = table.Column<int>(type: "int", nullable: false),
                    bolumid = table.Column<int>(type: "int", nullable: false),
                    unvani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    giristarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    cikistarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    kalankontor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personel_Kartlaris", x => x.kartno);
                    table.ForeignKey(
                        name: "FK_personel_Kartlaris_kod_Bolums_bolumid",
                        column: x => x.bolumid,
                        principalTable: "kod_Bolums",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade,
                        onUpdate: ReferentialAction.Cascade);
                table.ForeignKey(
                        name: "FK_personel_Kartlaris_kod_Departmen_departmanid",
                        column: x => x.departmanid,
                        principalTable: "kod_Departmen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade,
                        onUpdate: ReferentialAction.Cascade);
            table.ForeignKey(
                        name: "FK_personel_Kartlaris_kod_Sirkets_sirketid",
                        column: x => x.sirketid,
                        principalTable: "kod_Sirkets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade,
                        onUpdate: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hareketlers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kartno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarih_saat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ogunid = table.Column<int>(type: "int", nullable: false),
                    gecisdurum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hareketlers", x => x.id);
                    table.ForeignKey(
                        name: "FK_hareketlers_yemek_Oguns_ogunid",
                        column: x => x.ogunid,
                        principalTable: "yemek_Oguns",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade,
                        onUpdate: ReferentialAction.Cascade);
        });

            migrationBuilder.CreateIndex(
                name: "IX_hareketlers_ogunid",
                table: "hareketlers",
                column: "ogunid");

            migrationBuilder.CreateIndex(
                name: "IX_personel_Kartlaris_bolumid",
                table: "personel_Kartlaris",
                column: "bolumid");

            migrationBuilder.CreateIndex(
                name: "IX_personel_Kartlaris_departmanid",
                table: "personel_Kartlaris",
                column: "departmanid");

            migrationBuilder.CreateIndex(
                name: "IX_personel_Kartlaris_sirketid",
                table: "personel_Kartlaris",
                column: "sirketid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hareketlers");

            migrationBuilder.DropTable(
                name: "personel_Kartlaris");

            migrationBuilder.DropTable(
                name: "silinen_Personel_Kartlaris");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "yemek_Oguns");

            migrationBuilder.DropTable(
                name: "kod_Bolums");

            migrationBuilder.DropTable(
                name: "kod_Departmen");

            migrationBuilder.DropTable(
                name: "kod_Sirkets");
        }
    }
}
