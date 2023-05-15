using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace iPay88.BackedTest.CreditCardDefinitions;

public interface ICreditCardDefinitionRepository : IBasicRepository<CreditCardDefinition>
{
    Task<CreditCardDefinition> GetByCardNoAsync(int cardNo);
}