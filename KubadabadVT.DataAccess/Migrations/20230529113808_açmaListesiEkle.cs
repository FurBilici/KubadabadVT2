using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KubadabadVT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class açmaListesiEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AçmaListesis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AçmaAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AçmaAçıkMı = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AçmaListesis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AçmaListesis");
        }
    }
}
