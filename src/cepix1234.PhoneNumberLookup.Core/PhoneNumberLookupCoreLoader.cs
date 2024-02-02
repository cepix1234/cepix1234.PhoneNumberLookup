using cepix1234.PhoneNumberLookup.Core.HttpClient.Models;
using cepix1234.PhoneNumberLookup.Core.HttpClient;
using cepix1234.PhoneNumberLookup.Core.Constants;
using cepix1234.PhoneNumberLookup.Core.Constants.Model;
using cepix1234.PhoneNumberLookup.Core.Controllers;
using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.Logging;
using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using Microsoft.Extensions.DependencyInjection;

namespace cepix1234.PhoneNumberLookup.Core;

public class PhoneNumberLookupCoreLoader
{
    public PhoneNumberLookupCoreLoader(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IApiConstants, ApiConstants>();
        serviceCollection.AddSingleton<IHttpClientWrapper, HttpClientWrapper>();
        serviceCollection.AddSingleton<IClientController, ClientController>();
        serviceCollection.AddSingleton<IConsoleLogger, ConsoleLogger>();
    }
}