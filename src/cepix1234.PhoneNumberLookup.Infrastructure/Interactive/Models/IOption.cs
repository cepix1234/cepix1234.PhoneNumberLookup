namespace cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Models;

public interface IOption
{
    public string Message { get; }

    public Task Action();
}