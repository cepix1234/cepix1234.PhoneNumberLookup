using cepix1234.PhoneNumberLookup.Core.Controllers.Models;
using cepix1234.PhoneNumberLookup.Core.Logging.Models;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.FileCommand.Settings;
using Spectre.Console.Cli;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Commands.FileCommand;

public class FileCommand : AsyncCommand<FileCommandSettings>
{
    private readonly IClientController _clientController;
    private readonly IConsoleLogger _consoleLogger;
    
    public FileCommand(IClientController clientController, IConsoleLogger consoleLogger)
    {
        _clientController = clientController;
        _consoleLogger = consoleLogger;
    }
    
    public override async Task<int> ExecuteAsync(CommandContext context, FileCommandSettings settings)
    {
        string fileContent = await File.ReadAllTextAsync(settings.FilePath);
        foreach (string line in fileContent.Split(settings.Delimiter))
        {
            _consoleLogger.Log(await _clientController.GetNumberInformation(line.Trim()));
            Console.WriteLine("--------------------------------");
        }
        return 0;
    }
}