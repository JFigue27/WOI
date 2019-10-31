using Microsoft.EntityFrameworkCore.Migrations;

namespace WOI.Migrations
{
    public partial class JrzInv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JRZInventories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(nullable: true),
                    Plnt = table.Column<string>(nullable: true),
                    Batch = table.Column<string>(nullable: true),
                    MaterialDescription = table.Column<string>(nullable: true),
                    Typ = table.Column<string>(nullable: true),
                    StorageBin = table.Column<string>(nullable: true),
                    BUn = table.Column<string>(nullable: true),
                    TotalStock = table.Column<string>(nullable: true),
                    GRDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JRZInventories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JRZInventories");
        }
    }
}
