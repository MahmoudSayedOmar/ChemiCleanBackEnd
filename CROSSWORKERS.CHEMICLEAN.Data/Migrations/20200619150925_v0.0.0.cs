using Microsoft.EntityFrameworkCore.Migrations;

namespace CROSSWORKERS.CHEMICLEAN.Data.Migrations
{
    public partial class v000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "tblProduct",
            //    columns: table => new
            //    {
            //        ProductName = table.Column<string>(maxLength: 250, nullable: false),
            //        SupplierName = table.Column<string>(maxLength: 250, nullable: true),
            //        Url = table.Column<string>(maxLength: 300, nullable: false),
            //        UserName = table.Column<string>(maxLength: 50, nullable: true),
            //        Password = table.Column<string>(maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "tblProduct");
        }
    }
}
