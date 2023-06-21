using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenTienDung1512665.Migrations
{
    /// <inheritdoc />
    public partial class ManageHangHoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certification1512665De2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaChungChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenChungChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenDonViCap = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certification1512665De2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangHoaContext1512665De2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHangHoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenHangHoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHoaContext1512665De2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "itemsCertification1512665De2s2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CertificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemsCertification1512665De2s2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itemsCertification1512665De2s2_Certification1512665De2s_CertificationId",
                        column: x => x.CertificationId,
                        principalTable: "Certification1512665De2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itemsCertification1512665De2s2_HangHoaContext1512665De2s_ItemId",
                        column: x => x.ItemId,
                        principalTable: "HangHoaContext1512665De2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_itemsCertification1512665De2s2_CertificationId",
                table: "itemsCertification1512665De2s2",
                column: "CertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_itemsCertification1512665De2s2_ItemId",
                table: "itemsCertification1512665De2s2",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itemsCertification1512665De2s2");

            migrationBuilder.DropTable(
                name: "Certification1512665De2s");

            migrationBuilder.DropTable(
                name: "HangHoaContext1512665De2s");
        }
    }
}
