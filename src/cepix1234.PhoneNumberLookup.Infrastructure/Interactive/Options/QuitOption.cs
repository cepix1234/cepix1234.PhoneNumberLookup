using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Models;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Options;

public class QuitOption : IOption
{
    private static string _message = "Quit.";
    
    public string Message
    {
        get => _message;
    }
    public Task Action()
    {
        return Task.CompletedTask;
    }
}