namespace cepix1234.PhoneNumberLookup.Core.HttpClient.Models;

public interface IHttpClientWrapper
{
    public Task<string> GetAsync(string requestUri);
}