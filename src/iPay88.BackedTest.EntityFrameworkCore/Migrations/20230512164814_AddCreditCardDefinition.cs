using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iPay88.BackedTest.Migrations
{
    public partial class AddCreditCardDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCreditCardDefinitions",
                columns: table => new
                {
                    Bank = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CardNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCreditCardDefinitions", x => new { x.Bank, x.CardType, x.CardNo });
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppCreditCardDefinitions_CardNo",
                table: "AppCreditCardDefinitions",
                column: "CardNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCreditCardDefinitions");
        }
    }
}
