using AutoMapper;
using iPay88.BackedTest.CreditCardDefinitions;

namespace iPay88.BackedTest;

public class BackedTestApplicationAutoMapperProfile : Profile
{
    public BackedTestApplicationAutoMapperProfile()
    {
        CreateMap<CreditCardDefinition, CreditCardDefinitionDto>(MemberList.Destination)
            .ForMember(x => x.CardTypeLogo,
                option => option.MapFrom(x =>
                    x.CardType.Equals("VISA")
                        ? "visa.png"
                        : (x.CardType.Equals("MASTERCARD") ? "master-card.png" : "")));
    }
}
