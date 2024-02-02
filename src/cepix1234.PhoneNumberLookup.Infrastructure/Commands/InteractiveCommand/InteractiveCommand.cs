using cepix1234.PhoneNumberLookup.Infrastructure.Commands.InteractiveCommand.Settings;
using cepix1234.PhoneNumberLookup.Infrastructure.Interactive.Models;
using Spectre.Console.Cli;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Commands.InteractiveCommand;

public class InteractiveCommand : AsyncCommand<InteractiveCommandSettings>
{
    private readonly IInteractiveConsole _interactiveConsole;
    
    public InteractiveCommand(IInteractiveConsole interactiveConsole)
    {
        _interactiveConsole = interactiveConsole;
    }
    
    public override async Task<int> ExecuteAsync(CommandContext context, InteractiveCommandSettings settings)
    {
        await _interactiveConsole.run();
        return 0;
    }
}