using cepix1234.PhoneNumberLookup.Infrastructure.Interactive;
using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Options;
using Microsoft.Extensions.DependencyInjection;

namespace cepix1234.PhoneNumberLookup.Infrastructure;
public delegate IOption ServiceResolver(Type optionType);
public class PhoneNumberLookupInfraLoader
{
    public PhoneNumberLookupInfraLoader(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IOption, AccountOption>();
        serviceCollection.AddSingleton<IOption, NumberOption>();
        serviceCollection.AddSingleton<IOption, QuitOption>();

        serviceCollection.AddSingleton<ServiceResolver>(serviceProvider => optionType =>
        {
            var services = serviceProvider.GetServices<IOption>();
            return services.First(o => o.GetType() == optionType);
        });
        
        serviceCollection.AddSingleton<IInteractiveConsole, InteractiveConsole>();
    }
}