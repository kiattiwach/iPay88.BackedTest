using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iPay88.BackedTest.Migrations
{
    public partial class SeedCreditCardDefinition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"INSERT INTO dbo.AppCreditCardDefinitions
                        (Bank, CardType, CardNo)
                     VALUES
                        ('PT. BANK PERMATA TBK','VISA',489385),
		                ('PT. BANK BUKOPIN','VISA',489781),
		                ('PT BANK MANDIRI (PERSERO) TBK','VISA',490283),
		                ('PT BANK DANAMON INDONESIA TBK','VISA',490295),
		                ('PT BANK DANAMON INDONESIA TBK','VISA',490296),
		                ('BANK BALI','VISA',490702),
		                ('STANDARD CHARTERED BANK','VISA',493497),
		                ('BANK INTERNASIONAL INDONESIA','VISA',493828),
		                ('BANK INTERNASIONAL INDONESIA','VISA',493829),
		                ('PT. BANK PERMATA TBK','VISA',498853),
		                ('PT. ANZ PANIN BANK','MASTERCARD',510217),
		                ('PT. ANZ PANIN BANK','MASTERCARD',510249),
		                ('STANDARD CHARTERED BANK','MASTERCARD',510457),
		                ('PT. BANK RAKYAT INDONESIA (PERSERO)','MASTERCARD',510458)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AppCreditCardDefinitions");
        }
    }
}
