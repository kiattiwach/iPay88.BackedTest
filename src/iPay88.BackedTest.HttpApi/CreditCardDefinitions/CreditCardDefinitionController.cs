using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace iPay88.BackedTest.CreditCardDefinitions;

[RemoteService(Name = "BackedTest")]
[Area("backedTest")]
[ControllerName("CreditCardDefinition")]
[Route("api/app/credit-card-definition")]
public class CreditCardDefinitionController : AbpController, ICreditCardDefinitionService
{
    private readonly ICreditCardDefinitionService _creditCardDefinitionService;

    public CreditCardDefinitionController(ICreditCardDefinitionService creditCardDefinitionService)
    {
        _creditCardDefinitionService = creditCardDefinitionService;
    }

    [HttpGet]
    [Route("getByCardNo")]
    public Task<CreditCardDefinitionDto> GetByCardNoAsync(int cardNo)
    {
        return _creditCardDefinitionService.GetByCardNoAsync(cardNo);
    }
}