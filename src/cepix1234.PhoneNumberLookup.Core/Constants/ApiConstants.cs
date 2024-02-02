using System.Web;
using cepix1234.PhoneNumberLookup.Core.Models.Application;
using cepix1234.PhoneNumberLookup.Core.Constants.Model;
using Microsoft.Extensions.Options;

namespace cepix1234.PhoneNumberLookup.Core.Constants;

public class ApiConstants : IApiConstants
{
    public static readonly string ApiEndpoint = "https://ipqualityscore.com/api/json";

    private static readonly string ApiNumberLookup = "{0}/phone?key={1}&phone={2}";
    private static readonly string ApiAccountCredits = "{0}/account/{1}";

    private readonly AppSettings _appSettings;
    
    public ApiConstants(IOptions<AppSettings> appSettings)
    {
        _appSettings = appSettings.Value;
    }
    
    public string ApiRequestUrl(string number)
    {
        return String.Format(ApiNumberLookup, ApiEndpoint, _appSettings.ApiKey, HttpUtility.UrlEncode(number));
    }

    public string ApiAccountCreditsUrl()
    {
        return String.Format(ApiAccountCredits, ApiEndpoint, _appSettings.ApiKey);
    }
}