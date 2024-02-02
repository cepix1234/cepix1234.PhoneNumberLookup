using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.NumberCommand.Settings;
using Spectre.Console.Cli;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Commands.NumberCommand;

public class NumberCommand : AsyncCommand<NumberCommandSettings>
{
    private readonly IClientController _clientController;
    private readonly IConsoleLogger _consoleLogger;
    
    public NumberCommand(IClientController clientController, IConsoleLogger consoleLogger)
    {
        _clientController = clientController;
        _consoleLogger = consoleLogger;
    }
    
    public override async Task<int> ExecuteAsync(CommandContext context, NumberCommandSettings settings)
    {
        _consoleLogger.Log(await _clientController.GetNumberInformation(settings.PhoneNumber));
        return 0;
    }
}