using Microsoft.EntityFrameworkCore.Migrations;

namespace WOI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkOrderNumber = table.Column<string>(nullable: true),
                    MaterialNumber = table.Column<string>(nullable: true),
                    Seq_no_ = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true),
                    MaterialDescription = table.Column<string>(nullable: true),
                    Target_qty = table.Column<string>(nullable: true),
                    Del_qty = table.Column<string>(nullable: true),
                    Bsc_start = table.Column<string>(nullable: true),
                    Release = table.Column<string>(nullable: true),
                    MRP_ctrlr = table.Column<string>(nullable: true),
                    Order_Type = table.Column<string>(nullable: true),
                    System_Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkOrders");
        }
    }
}
