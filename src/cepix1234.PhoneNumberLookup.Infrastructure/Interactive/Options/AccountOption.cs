using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Models;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Options;

public class AccountOption : IOption
{
    private static string _message = "Get account information.";
    
    private readonly IClientController _clientController;
    private readonly IConsoleLogger _consoleLogger;
    
    public AccountOption(IClientController clientController, IConsoleLogger consoleLogger)
    {
        _clientController = clientController;
        _consoleLogger = consoleLogger;
    }

    public string Message
    {
        get => _message;
    }

    public async Task Action()
    {
        _consoleLogger.Log(await _clientController.GetAccountCreditInformation());
    }
}