using System.ComponentModel;
using cepix1234.PhoneNumberLookup.Infrastructure.Commands.FileCommand.Validation;
using Spectre.Console.Cli;

namespace cepix1234.PhoneNumberLookup.Infrastructure.Commands.FileCommand.Settings;
public class FileCommandSettings : CommandSettings
{
    [CommandArgument(0, "<FilePath>")]
    [Description("Path to file location")]
    [FileCommandValidation]
    public string FilePath { get; set; } = string.Empty;
    
    
    [CommandArgument(1, "[delimiter]")]
    [Description("Delimiter for numbers")]
    public string Delimiter { get; set; } = "\r\n";
}