using System.Text.Json;
using cepix1234.PhoneNumberLookup.Core.Constants.Model;
using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.HttpClient.Models;
using cepix1234.PhoneNumberLookup.Core.Models.AcountInfo;
using cepix1234.PhoneNumberLookup.Core.Models.NumberInfo;

namespace cepix1234.PhoneNumberLookup.Core.Controllers;

public class ClientController: IClientController
{
    private readonly IApiConstants _apiConstants;
    private readonly IHttpClientWrapper _clientWrapper;

    public ClientController(IApiConstants apiConstants, IHttpClientWrapper clientWrapper)
    {
        _apiConstants = apiConstants;
        _clientWrapper = clientWrapper;
    }

    public async Task<NumberInformation?> GetNumberInformation(string number)
    {
        string json = await _clientWrapper.GetAsync(_apiConstants.ApiRequestUrl(number));
        return JsonSerializer.Deserialize<NumberInformation>(json);
    }

    public async Task<AccountCredit?> GetAccountCreditInformation()
    {
        string json = await _clientWrapper.GetAsync(_apiConstants.ApiAccountCreditsUrl());
        return JsonSerializer.Deserialize<AccountCredit>(json);
    }
}