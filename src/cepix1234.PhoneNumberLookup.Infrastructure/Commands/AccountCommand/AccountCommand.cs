using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.AccountCommand.Settings;
using Spectre.Console.Cli;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Commands.AccountCommand;

public class AccountCommand: AsyncCommand<AccountCommandSettings>
{
    private readonly IClientController _clientController;
    private readonly IConsoleLogger _consoleLogger;
    
    public AccountCommand(IClientController clientController, IConsoleLogger consoleLogger)
    {
        _clientController = clientController;
        _consoleLogger = consoleLogger;
    }
    
    public override async Task<int> ExecuteAsync(CommandContext context, AccountCommandSettings settings)
    {
        _consoleLogger.Log(await _clientController.GetAccountCreditInformation());
        return 0;
    }
}