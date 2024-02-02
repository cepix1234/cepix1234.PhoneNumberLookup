using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Models;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Options;

public class NumberOption : IOption
{
    private static string _message = "Scan a phone number.";
    
    private readonly IClientController _clientController;
    private readonly IConsoleLogger _consoleLogger;
    
    public NumberOption(IClientController clientController, IConsoleLogger consoleLogger)
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
        Console.WriteLine("Enter phone number to scan:");
        string phoneNumber = Console.ReadLine().ToString();
        _consoleLogger.Log(await _clientController.GetNumberInformation(phoneNumber));
    }
}