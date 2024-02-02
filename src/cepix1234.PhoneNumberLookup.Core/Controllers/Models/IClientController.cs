using cepix1234.PhoneNumberLookup.Core.Models.AcountInfo;
using cepix1234.PhoneNumberLookup.Core.Models.NumberInfo;

namespace cepix1234.PhoneNumberLookup.Core.Controllers.Models;

public interface IClientController
{
    public Task<NumberInformation?> GetNumberInformation(string number);

    public Task<AccountCredit?> GetAccountCreditInformation();
}