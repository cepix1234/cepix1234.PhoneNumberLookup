using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using cepix1234.PhoneNumberLookup.Core.Models.Interfaces;

namespace cepix1234.PhoneNumberLookup.Core.Logging;

public class ConsoleLogger: IConsoleLogger
{
    public void Log(IBaseObject? baseObject)
    {
        Console.WriteLine(baseObject?.ToString());
    }
}