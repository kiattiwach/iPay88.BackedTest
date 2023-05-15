using System.Linq;
using System.Threading.Tasks;
using iPay88.BackedTest.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace iPay88.BackedTest.CreditCardDefinitions;

public class CreditCardDefinitionRepository : EfCoreRepository<BackedTestDbContext, CreditCardDefinition>, ICreditCardDefinitionRepository
{
    public CreditCardDefinitionRepository(IDbContextProvider<BackedTestDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<CreditCardDefinition> GetByCardNoAsync(int cardNo)
    {
        return (await GetDbSetAsync()).FirstOrDefault(x => x.CardNo == cardNo);
    }
}