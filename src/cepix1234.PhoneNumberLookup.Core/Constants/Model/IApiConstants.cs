namespace cepix1234.PhoneNumberLookup.Core.Constants.Model;

public interface IApiConstants
{
    /// <summary>
    /// Api endpoint used for api calls.
    /// </summary>
    public static string ApiEndpoint { get; }

    /// <summary>
    /// Get Url for api request to get number information.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    string ApiRequestUrl(string number);

    /// <summary>
    /// Get Url for api request to get account credentials status.
    /// </summary>
    /// <returns></returns>
    string ApiAccountCreditsUrl();
}