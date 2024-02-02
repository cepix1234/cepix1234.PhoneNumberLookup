using cepix1234.PhoneNumberLookup.Core.HttpClient.Models;

namespace cepix1234.PhoneNumberLookup.Core.HttpClient;

public class HttpClientWrapper: IHttpClientWrapper
{
    private readonly System.Net.Http.HttpClient _httpClient;

    public HttpClientWrapper()
    {
        _httpClient = new System.Net.Http.HttpClient();
    }
    public async Task<string> GetAsync(string requestUri)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}