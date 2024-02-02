using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Spectre.Console.Cli;
using Spectre.Console.Cli.Extensions.DependencyInjection;
using cepix1234.PhoneNumberLookup.Core.Models.Application;
using cepix1234.PhoneNumberLookup.Core;
using cepix1234.PhoneNumberLookup.Infrastructure;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.AccountCommand;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.FileCommand;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.InteractiveCommand;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.NumberCommand;

var serviceCollection = new ServiceCollection()
    .AddLogging(configure =>
        configure
            .AddSimpleConsole(opts => { opts.TimestampFormat = "yyyy-MM-dd HH:mm:ss "; })
    );

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables().Build();

serviceCollection.Configure<AppSettings>(configuration.GetSection("Settings"));
RegisterServices(serviceCollection);

using var registrar = new DependencyInjectionRegistrar(serviceCollection);
var app = new CommandApp(registrar);
app.Configure(
    config =>
    {
        config.ValidateExamples();
        
        config.AddCommand<FileCommand>("file")
            .WithAlias("f")
            .WithDescription("Lookup numbers within a file separated by delimiter (default new line).")
            .WithExample(new [] {"file", "<FileName>", "[Delimiter]"});
        
        config.AddCommand<NumberCommand>("number")
            .WithAlias("n")
            .WithDescription("Lookup a single number.")
            .WithExample(new[] { "number", "<PhoneNumber>" });
        
        config.AddCommand<AccountCommand>("account")
            .WithAlias("a")
            .WithDescription("Check account credit information.")
            .WithExample(new[] {"account"});

        config.AddCommand<InteractiveCommand>("interactive")
            .WithAlias("i")
            .WithDescription("Run in interactive mode.")
            .WithExample(new[] { "interactive" });
    });

return await app.RunAsync(args);

void RegisterServices(IServiceCollection services)
{
    // ReSharper disable once ObjectCreationAsStatement no need since we are just registering services.
    new PhoneNumberLookupCoreLoader(services);
    new PhoneNumberLookupInfraLoader(services);
}