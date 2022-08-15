using Microsoft.EntityFrameworkCore.Migrations;

namespace KarekodBarkodUygulaması.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productBarkod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productBarkodImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    karekodImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productAdet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.productID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
