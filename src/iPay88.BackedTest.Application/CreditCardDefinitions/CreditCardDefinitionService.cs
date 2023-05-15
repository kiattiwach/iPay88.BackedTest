using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace iPay88.BackedTest.CreditCardDefinitions;

public class CreditCardDefinitionService : BackedTestAppService, ICreditCardDefinitionService
{
    private readonly ICreditCardDefinitionRepository _repository;

    public CreditCardDefinitionService(ICreditCardDefinitionRepository repository)
    {
        _repository = repository;
    }
    public async Task<CreditCardDefinitionDto> GetByCardNoAsync(int cardNo)
    {
        return ObjectMapper.Map<CreditCardDefinition, CreditCardDefinitionDto>(
            await _repository.GetByCardNoAsync(cardNo));
    }
}