using System;
using Volo.Abp.Domain.Entities;

namespace iPay88.BackedTest.CreditCardDefinitions;

public class CreditCardDefinition : Entity
{
    public string Bank { get; set; }
    public string CardType { get; set; }//todo-cardType should be enum.
    public int CardNo { get; set; }
    public string Logo { get; set; }

    public CreditCardDefinition(string bank, string cardType, int cardNo, string logo)
    {
        Bank = bank;
        CardType = cardType;
        CardNo = cardNo;
        Logo = logo;
    }

    public override object[] GetKeys()
    {
        return new object[]
        {
            Bank, CardType, CardNo
        };
    }
}