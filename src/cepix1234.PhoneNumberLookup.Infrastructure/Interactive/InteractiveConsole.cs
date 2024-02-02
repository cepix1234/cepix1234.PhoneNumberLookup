using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Options;
using Microsoft.Extensions.DependencyInjection;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Interactive;

public class InteractiveConsole: IInteractiveConsole
{
    private readonly IOption[] _options;
    
    public InteractiveConsole(ServiceResolver serviceResolver)
    {
        _options = new IOption[] { serviceResolver(typeof(AccountOption)),serviceResolver(typeof(NumberOption)),serviceResolver(typeof(QuitOption)) };
    }

    public async Task run()
    {
        int option = -1;
        while (option < _options.Length - 1)
        {
            Console.WriteLine("---------------------------------------------");
            DisplayOptions();
            option = Convert.ToInt32(Console.ReadLine()?.ToString());
            Console.Clear();
            await _options[option].Action();
        }
    }

    private void DisplayOptions()
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i<_options.Length; i++)
        {
            Console.WriteLine($"{i}: {_options[i].Message}");
        }

        Console.WriteLine("---------------------------------------------");
    }
}