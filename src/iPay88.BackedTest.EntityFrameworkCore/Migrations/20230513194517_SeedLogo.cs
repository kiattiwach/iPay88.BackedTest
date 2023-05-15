using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iPay88.BackedTest.Migrations
{
    public partial class SeedLogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'PERMATA.png' where CardNo = 489385");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'BUKOPIN.png' where CardNo = 489781");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'MANDIRI.png' where CardNo = 490283");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'DANAMON.png' where CardNo = 490295");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'DANAMON.png' where CardNo = 490296");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'BALI.png' where CardNo = 490702");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'CHARTERED.png' where CardNo = 493497");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'BANKINTERNASIONALINDONESIA.png' where CardNo = 493828");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'BANKINTERNASIONALINDONESIA.png' where CardNo = 493829");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'PERMATA.png' where CardNo = 498853");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'ANZPANIN.png' where CardNo = 510217");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'ANZPANIN.png' where CardNo = 510249");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'CHARTERED.png' where CardNo = 510457");
            migrationBuilder.Sql("Update dbo.AppCreditCardDefinitions set Logo = 'RAKYAT.png' where CardNo = 510458");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
