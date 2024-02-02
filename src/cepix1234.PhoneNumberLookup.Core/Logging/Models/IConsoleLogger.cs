using cepix1234.PhoneNumberLookup.Core.Models.Interfaces;

namespace cepix1234.PhoneNumberLookup.Core.Logging.Models;

public interface IConsoleLogger
{
    void Log (IBaseObject? baseObject);
}