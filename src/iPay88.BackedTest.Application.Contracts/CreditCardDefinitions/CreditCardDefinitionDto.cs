using Volo.Abp.Application.Dtos;

namespace iPay88.BackedTest.CreditCardDefinitions;

public class CreditCardDefinitionDto : EntityDto
{
    public string Bank { get; set; }
    public string CardType { get; set; }
    public string Logo { get; set; }
    public string CardTypeLogo { get; set; }
}