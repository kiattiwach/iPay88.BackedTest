using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace iPay88.BackedTest.CreditCardDefinitions;

public interface ICreditCardDefinitionService : IApplicationService
{
    Task<CreditCardDefinitionDto> GetByCardNoAsync(int cardNo);
}